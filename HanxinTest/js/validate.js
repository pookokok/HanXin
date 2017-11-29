//整数
function RequireInteger(obj) {
    var reg_int = /^[-+]?\d+$/;
    var result = reg_int.test(obj);
    if (result === true) {
        return true;
    } else {
        return false;
    }
}

//整数 可空
function RequireIntegerOrNull(obj) {
    var reg_int = /^[-+]?\d+$/;
    var result = reg_int.test(obj || (obj == ''));
    if (result === true) {
        return true;
    } else {
        return false;
    }
}


//小数验证 可空
function RequireDecimalOrNull(obj) {
    var reg_Decimal = /^-?[0-9]*(\.\d*)?$|^-?d^(\.\d*)?$/;
    var result = reg_Decimal.test(obj || (obj == ''));
    if (result === true) {
        return true;
    } else {
        return false;
    }
}

//字数控制
function RequireMaxNum(obj, max) {
    var content = obj;
    if (content.length >= 0 && content.length <= max) {
        return true;
    }
    else {
        return false;
    }
}

//固定字数控制
function RequireNum(obj, num) {
    var content = obj;
    if (content.length == num) {
        return true;
    }
    else {
        return false;
    }
}

//GS1的应用标识符数据字段的编码字符集
function RequireGS(obj) {
    var reg_GS = /^[A-Za-z0-9 !“’()*+,-.:;=_]+$/;
    var result = reg_GS.test(obj);
    if (result === true) {
        return true;
    } else {
        return false;
    }
}

//GS1的应用标识符数据字段的编码字符集 可空
function RequireGSOrNull(obj)
{
    var reg_GS = /^[A-Za-z0-9 !“’()*+,-.:;=_]+$/;
    var result = reg_GS.test(obj || (obj == ''));
    if (result === true) {
        return true;
    } else {
        return false;
    }
}







