function GSValidate(mark, str) {
    var r = true;
    //var msgError = eval('StaticCommodityAttributeName.' + mark);
    //var f = eval('StaticCommodityAttributeFormat.' + mark);
    var msg = eval('StaticCommodityAttribute.Name.' + mark);
    var f = eval('StaticCommodityAttribute.Format.' + mark);
    var _a_f = f.split('+');
    $.each(_a_f, function (k, v) {

        //N验证
        if (v.indexOf('N') > -1)
        {
            r = RequireInteger(str);
            if (!r) { return r }
            if (v.indexOf('N..') > -1)
            {
                v = v.replace('N..', '');
                r = RequireMaxNum(str, v);
                if (!r) { return r }

            }
            else {
                v = v.replace('N', '');
                r = RequireNum(str, v);
                if (!r) { return r }

            }
        }

        //X验证
        if(v.indexOf('X')>-1)
        {
            r = RequireGS(str);
            if (!r) { return r }

            if (v.indexOf('X..') > -1) {
                v = v.replace('X..', '');
                r = RequireMaxNum(str, v);
                if (!r) { return r }

            }
            else {
                v = v.replace('X', '');
                r = RequireNum(str, v);
                if (!r) { return r }

            }

        }
    })
    
    alert(r + msg)
    return r
}


//function GSValidate(str) {
//    switch (str) {
//        case 'gtin': break;	//全球贸易项目代码N14
//        case 'bat': break;	//批号X..20
//        case 'pro': break;	//生产日期N6
//        case 'due': break;	//付款截止日期N6
//        case 'pac': break;	//包装日期N6
//        case 'exp': break;	//有效期N6
//        case 'var': break;	//产品变体N2
//        case 'ser': break;	//系列号X..20
//        case 'aii': break;	//附加产品标识X..30
//        case 'cpn': break;	//客户方代码X..30
//        case 'mto': break;	//定制产品代码N..6
//        case 'ssn': break;	//二级系列号X..30
//        case 'rse': break;	//源实体参考代码X..30
//        case 'civ': break;	//可变数量N..8
//        case 'nwk': break;	//净重，千克（变量贸易项目）N6
//        case 'lfm': break;	//长度或第一尺寸，米（变量贸易项目）N6
//        case 'wdsm': break;	//宽度、直径或第二尺寸，米（变量贸易项目）N6
//        case 'dthtm': break;	//深度、厚度、高度或第三尺寸，米（变量贸易项目）N6
//        case 'asm': break;	//面积，平方米（变量贸易项目）N14
//        case 'nvl': break;	//净容积或净体积，升（变量贸易项目）N6
//        case 'nvcm': break;	//净容积或净体积，立方米（变量贸易项目）N6
//        case 'coti': break;	//贸易项目的原产国（或地区）N3
//        case 'cip': break;	//贸易项目初始加工的国家（或地区）N3＋N..12
//        case 'cp': break;	//贸易项目加工的国家（或地区）N3
//        case 'cd': break;	//贸易项目拆分的国家（或地区）N3
//        case 'ccpc': break;	//全程加工贸易项目的国家（地区）N3
//        case 'mccc': break;	//UN/ECE胴体肉与分割产品分类X..30
//        case 'edt': break;	//产品的有效日期和时间N10
//        case 'anp0': break;	//ISO国家代码的加工者核准号：屠宰场N3＋X..27
//        case 'anp1': break;	//ISO国家代码的加工者核准号：第一加工厂N3＋X..27
//        case 'anp2': break;	//ISO国家代码的加工者核准号：第二加工厂N3＋X..27
//        case 'anp3': break;	//ISO国家代码的加工者核准号：第三加工厂N3＋X..27
//        case 'anp4': break;	//ISO国家代码的加工者核准号：第四加工厂N3＋X..27
//        case 'anp5': break;	//ISO国家代码的加工者核准号：第五加工厂N3＋X..27
//        case 'anp6': break;	//ISO国家代码的加工者核准号：第六加工厂N3＋X..27
//        case 'anp7': break;	//ISO国家代码的加工者核准号：第七加工厂N3＋X..27
//        case 'anp8': break;	//ISO国家代码的加工者核准号：第八加工厂N3＋X..27
//        case 'anp9': break;	//ISO国家代码的加工者核准号：第九加工厂N3＋X..27
//        case 'rp': break;	//卷状产品N14
//        case 'ppum': break;	//单价N6
//        case 'icti': break;	//贸易项目组件的标识N14＋N2＋N2
//        case 'dtp': break;	//产品生产的日期与时间N8＋N..4
//        case 'epurl': break;	//包装扩展信息网址X..70
//        case 'imabtp': break;	//贸易伙伴之间相互约定的信息X..30
//        case 'cii1': break;	//公司内部信息X..30
//        case 'cii2': break;	//公司内部信息
//        case 'cii3': break;	//公司内部信息
//        case 'cii4': break;	//公司内部信息
//        case 'cii5': break;	//公司内部信息
//        case 'cii6': break;	//公司内部信息
//        case 'cii7': break;	//公司内部信息
//        case 'cii8': break;	//公司内部信息
//        case 'cii9': break;	//公司内部信息
//    }
//}