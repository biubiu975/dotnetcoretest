var ValidateObj = {};

//验证正整数
ValidateObj.validatorNum = function (rule, value, callback) {
    var reg = /^[0-9]*[1-9][0-9]*$/;
    var result = reg.test(value);
    if (result) {
        callback();
    } else {
        callback(new Error('请输入正整数!'));
    }
}

//验证日期
ValidateObj.validatorDate = function (rule, value, callback) {
    if (isDate(value)) {
        callback();
    } else {
        callback(new Error('请输入正确的日期'));
    }
}


//正数
function isDecimal(item) {
    var pattern = /^(([1-9]\d*)|([1-9]\d*\.\d{1,})|(0\.\d*[1-9]\d*))$/;
    if (pattern.test(item)) {
        return true;
    } else {
        return false;
    }
}

//正数，最多16位，小数点后最多5位（米）//初值修改使用
function isDecimalByM(val) {
    var pattern = /^((\d{0,16})|([1-9]\d{0,10}\.\d{1,5})|(0\.\d{0,1}[1-9]))$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//正数，最多16位，小数点后最多2位（毫米）
function isDecimalByMM(val) {
    var pattern = /^(([1-9]\d{0,15})|([1-9]\d{0,13}\.\d{1,2})|(0\.\d{0,1}[1-9]))$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//正数，最多16位，小数点后最多8位（坐标）
function isDecimalByL(val) {
    var pattern = /^((\d{0,16})|([1-9]\d{0,7}\.\d{1,8})|(0\.\d{0,7}[1-9]))$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//坐标，最多16位，小数点后最多8位
function isDecimalByXYZ(val) {
    var pattern = /^(-|\+)?((\d{0,16})|([1-9]\d{0,7}\.\d{1,8})|(0\.\d{0,7}[1-9]))$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//负数 正数 小数
function IsDecimalValue(val) {
    var pattern = /^(\-|\+)?\d+(\.\d+)?$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}
//负数 且小数最多8位
function IsDecimalValue_8(val) {
    debugger;
    var pattern = /^\-((\d+(\.\d{0,8})?)|(\d*\.\d{1,8}))$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//负数 正数 小数
function IsDecimalValueFive(val) {
    var pattern = /^[+-]?\d+(?:\.\d{1,5})?$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//负数 正数 小数
function IsDecimalValueOneFive(val) {
    var pattern = /^[+-]?\d+(?:\.\d{1,15})?$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

function IsDecimalValue0(val, type) {
    var pattern = /^[0]+(\.\d{1,4})$/; //以0开头的小数4位
    if (type == "1") {
        if (pattern.test(val)) {
            return true;
        } else {
            return false;
        }
    } else if (type == "2") { // 正浮点数，小数最大4位
        pattern = /^\d+(\.\d{1,4})$/;
        if (pattern.test(val)) {
            return true;
        } else {
            return false;
        }
    } else {
        return false;
    }
}


function IsDecimalValueEight(val) {
    var pattern = /^[+-]?\d+(?:\.\d{1,8})?$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//日期
function isDate(val) {
    var pattern = /^[1-9]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}

//手机号
function isTel(val) {
    var pattern = /^(1[3,4,5,6,7,8,9])\d{9}$/;
    if (pattern.test(val)) {
        return true;
    } else {
        return false;
    }
}


function isEmail(val) {
    var email = /^([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/gi;
    if (email.test(val)) {
        return true;
    } else {
        return false;
    }
}

//字符串为空
function isEmpty(obj) {
    if (typeof obj == "undefined" || obj == null || obj == "") {
        return true;
    } else {
        return false;
    }
}

function trim(str) {
    return str.replace(/(^\s*)|(\s*$)/g, "");
}

String.prototype.trim = function () {
    return trim(this);
}

function doubleFormatter(cellValue, count) {
    var temp = parseFloat(cellValue);
    if (isNaN(temp)) {
        return "-";
    }
    return this.toPercision(temp, count);
};
function toPercision(x, count) {
    if (x === 0) {
        return 0;
    } else {
        var temp = parseFloat(x);
        if (isNaN(temp)) {
            return false;
        }
        var f = Math.round(x * Math.pow(10, count)) / Math.pow(10, count);
        var s = f.toString();
        var rs = s.indexOf('.');
        if (rs < 0) {
            rs = s.length;
            s += '.';
        }
        while (s.length <= rs + count) {
            s += '0';
        }
        return s;
    }

};



//获取url参数
function GetQueryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return decodeURI(r[2]);
    return "";
}

function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split("&");
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split("=");
        if (pair[0] == variable) {
            return decodeURI(pair[1]);
        }
    }

    return '';
}