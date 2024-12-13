using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Class
{
    public class Menu
    {


        //public List<mPDCData> dataReview()
        //{
        //    jbp = new SqlParameter[1];


        //    jbp[0] = new SqlParameter("@jobID_Pk", SqlDbType.Int, 18);
        //    jbp[0].Value = jobID_Pk;

        //    using (SqlDataReader fsl = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "dataBundleForView"))
        //    {
        //        List<mPDCData> _data = new List<mPDCData>();
        //        if (fsl.HasRows)
        //        {
        //            while (fsl.Read())
        //            {
        //                _data.Add(new mPDCData
        //                {

        //                    jobID_Pk = int.Parse(fsl["jobID_Pk"].ToString()),
        //                    styleNumber = fsl["styleNumber"].ToString(),
        //                    description = fsl["description"].ToString(),
        //                    imgPath = fsl["imgPath"].ToString(),
        //                    category = fsl["category"].ToString(),
        //                    customer = fsl["customer"].ToString(),
        //                    fitName = fsl["fitName"].ToString(),
        //                    totalQuantity = int.Parse(fsl["totalQuantity"].ToString()),
        //                    garmentTechName = fsl["garmentTechName"].ToString(),
        //                    obdTechName = fsl["obdTechName"].ToString(),
        //                    patterMakerName = fsl["patterMakerName"].ToString(),
        //                    merchantName = fsl["merchantName"].ToString(),
        //                    planSendDate = fsl["planSendDate"].ToString(),
        //                    approvalType = fsl["approvalType"].ToString(),
        //                    approvedQuantity = int.Parse(fsl["approvedQuantity"].ToString()),
        //                    rejectedQuantity = int.Parse(fsl["rejectedQuantity"].ToString()),
        //                    customerRejectReason = fsl["customerRejectReason"].ToString(),


        //                });
        //            }
        //        }



        //        return _data;

        //    }

        //}


    }
}