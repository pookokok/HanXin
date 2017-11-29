using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HanxinTest
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt1.Value = "达髓阿淤懈锐胯笫笳莸甾桤荇和后寝箫溱菁眢Ｄ够恋邱擦蚧俪袤驷氽裟忾茔1223444454xddfgfgff地址：北京市东城区安定门外大街136号皇城国际中心B座4层（100011）北京市东城区安定门外大街136号皇城国际中心B座4层（100011）";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbl.InnerText = txt1.Value.Length.ToString();

            string imgname = DateTime.Now.ToString("yyyyMMddhhmmss");

            string szData1 = txt1.Value;

            string file_input1 = "test1.txt";
            int iWidth = 0;

            int iScale = Convert.ToInt32(txtiScale.Value);
            int iSpace = 8;
            int iRsLevel = int.Parse(txtiRsLevel.Value);
            int iSetVersion = 0;

            string path = "#";
            string _outFile1 = "img/" + imgname + ".bmp";
            string outFile2 = "2.bmp";
            string outFile3 = "3.bmp";
            int i = 0;
            int j = 0;

            byte[] bb = new byte[189 * 189];

            int szInfoNum;

            byte[] szInfo = new byte[5000];

            path = HttpContext.Current.Server.MapPath(_outFile1);

            //iWidth =HanxinCodeHandler.EnCsFile(file_input1, iSetVersion, iRsLevel, iScale, iSpace, bb, outFile3);
            //iWidth = HanxinCodeHandler.EnCsText(szData1, iSetVersion, iRsLevel, iScale, iSpace, bb, path);

            iWidth = BLL.HXHandler.EnCsText(szData1, iSetVersion, iRsLevel, iScale, iSpace, bb, path);

            if (iWidth > 0)
            {
                //szInfoNum = HanxinCodeHandler.DeCodeCsbyte(bb, iWidth, szInfo);

                szInfoNum = BLL.HXHandler.DeCodeCsbyte(bb, iWidth, szInfo);

                if (szInfoNum > 0)
                {
                    img.Src = _outFile1;
                }
            }


        }
    }
}