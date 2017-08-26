 

//数据库基本信息设置
//获取数据库中各表基本数据
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataBaseEntity
{
    public class access_count
    { 
        public int access_TotalCount { get; set; } 
    }
    public class access_info
    { 
        public string ip { get; set; } 
 
        public string address { get; set; } 
 
        public string ipSrc { get; set; } 
 
        public DateTime time { get; set; } 
    }
    public class add_subtract_t
    { 
        public string MERCHANT { get; set; } 
 
        public decimal AMOUNT { get; set; } 
 
        public string ITEM { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public string SLT_STATUS { get; set; } 
    }
    public class admin_usersinfo
    { 
        public string admin_Id { get; set; } 
 
        public string admin_Name { get; set; } 
 
        public string admin_Pwd { get; set; } 
 
        public string admin_PhoneNum { get; set; } 
 
        public string admin_Email { get; set; } 
 
        public string admin_Role { get; set; } 
 
        public string admin_AmendTime { get; set; } 
    }
    public class bak_repair_pricelist
    { 
        public string pro_Type { get; set; } 
 
        public string pro_Brand { get; set; } 
 
        public string pro_Model { get; set; } 
 
        public string err_Type { get; set; } 
 
        public string err_Item { get; set; } 
 
        public string re_Price { get; set; } 
 
        public int forder { get; set; } 
    }
    public class bom
    { 
        public string Bom_Type { get; set; } 
 
        public string Bom_Category { get; set; } 
 
        public string Bom_Name { get; set; } 
 
        public string Bom_Brand { get; set; } 
 
        public string Bom_Model { get; set; } 
 
        public string Bom_Specification { get; set; } 
 
        public string Bom_Parameter { get; set; } 
 
        public string Bom_Remark { get; set; } 
 
        public string Bom_Date { get; set; } 
    }
    public class check_details
    { 
        public int Check_Product_Details_ID { get; set; } 
 
        public string Check_Details_OrderID { get; set; } 
 
        public int Check_Details_Score { get; set; } 
 
        public string Check_Details_Remark { get; set; } 
 
        public DateTime Check_Details_Date { get; set; } 
 
        public string Check_Details_Remain1 { get; set; } 
 
        public string Check_Details_Remain2 { get; set; } 
    }
    public class check_item
    { 
        public int Check_Type_ID { get; set; } 
 
        public int Check_Product_Details_ID { get; set; } 
 
        public string Check_ItemValue { get; set; } 
 
        public string Check_Item_Remain1 { get; set; } 
 
        public string Chekc_Item_Remain2 { get; set; } 
    }
    public class check_item_details
    { 
        public int Check_Item_ID { get; set; } 
 
        public string Check_Item_Details { get; set; } 
 
        public string Check_Item_Remain1 { get; set; } 
 
        public string Check_Item_Remain2 { get; set; } 
    }
    public class check_product_details
    { 
        public string Check_Product_Type { get; set; } 
 
        public string Check_Product_Brand { get; set; } 
 
        public string Check_Product_Model { get; set; } 
 
        public string Check_Product_Remain1 { get; set; } 
 
        public string Check_Product_Remain2 { get; set; } 
    }
    public class check_score
    { 
        public int Check_Item_Details_ID { get; set; } 
 
        public int Check_Score_Value { get; set; } 
 
        public string Check_Score_Remain1 { get; set; } 
 
        public string Check_ScoreRemain2 { get; set; } 
    }
    public class check_summary
    { 
        public string Check_Summary_OrderID { get; set; } 
 
        public string Check_Summary_Inspector { get; set; } 
 
        public string Check_Summary_ShopID { get; set; } 
 
        public string Check_Summary_Surface { get; set; } 
 
        public string Check_Summary_Battery { get; set; } 
 
        public string Check_Summary_Power { get; set; } 
 
        public string Check_Summary_Final { get; set; } 
 
        public string Check_Summary_Remark { get; set; } 
 
        public string Check_Summary_Conclusion { get; set; } 
 
        public DateTime Check_Date { get; set; } 
    }
    public class check_type
    { 
        public string Check_Type { get; set; } 
 
        public string Check_Product_Type { get; set; } 
    }
    public class citycode_t
    { 
        public string CITY { get; set; } 
 
        public string PROVINCECODE { get; set; } 
 
        public string CITYLEVEL { get; set; } 
 
        public string CITYCODE { get; set; } 
 
        public string DEL_FLAG { get; set; } 
    }
    public class cus_applylist
    { 
        public string cus_StoreName { get; set; } 
 
        public int cus_StoreSize { get; set; } 
 
        public int cus_StoreTurnover { get; set; } 
 
        public int cus_PersonCount { get; set; } 
 
        public string cus_Equipment { get; set; } 
 
        public string cus_Level { get; set; } 
 
        public string cus_Address_Province { get; set; } 
 
        public string cus_Address_City { get; set; } 
 
        public string cus_Address_County { get; set; } 
 
        public string cus_Address_Town { get; set; } 
 
        public string cus_Address_Detail { get; set; } 
 
        public string cus_RepairScope { get; set; } 
 
        public string cus_StoreImg { get; set; } 
 
        public string cus_StoreInfo { get; set; } 
 
        public string cus_ApplyTime { get; set; } 
 
        public string cus_contact_window { get; set; } 
 
        public string cus_phone_number { get; set; } 
 
        public int cal_id { get; set; } 
 
        public string cus_identityCard { get; set; } 
 
        public string cus_AccountNo { get; set; } 
 
        public string cus_paytype { get; set; } 
 
        public string shop_certificate { get; set; } 
    }
    public class cus_cusinfolist
    { 
        public string cus_Id { get; set; } 
 
        public string cus_Name { get; set; } 
 
        public string cus_Sex { get; set; } 
 
        public string cus_Age { get; set; } 
 
        public string cus_Img { get; set; } 
 
        public string cus_PhoneNum { get; set; } 
 
        public string cus_CardId { get; set; } 
 
        public string cus_TelephoneNum { get; set; } 
 
        public string cus_Email { get; set; } 
 
        public string cus_StoreName { get; set; } 
 
        public string cus_StoreSize { get; set; } 
 
        public string cus_StoreTurnover { get; set; } 
 
        public string cus_PersonCount { get; set; } 
 
        public string cus_Equipment { get; set; } 
 
        public string cus_Level { get; set; } 
 
        public string cus_Address_Province { get; set; } 
 
        public string cus_Address_City { get; set; } 
 
        public string cus_Address_County { get; set; } 
 
        public string cus_Address_Town { get; set; } 
 
        public string cus_Address_Detail { get; set; } 
 
        public string cus_RepairScope { get; set; } 
 
        public string cus_StoreImg { get; set; } 
 
        public string cus_StoreInfo { get; set; } 
 
        public string cus_ApplyPassTime { get; set; } 
    }
    public class cus_cusmanagersinfo
    { 
        public string cus_Id { get; set; } 
 
        public string cus_Pwd { get; set; } 
 
        public string cus_Name { get; set; } 
 
        public string cus_PhoneNum { get; set; } 
 
        public string cus_Rights { get; set; } 
 
        public string cus_Img { get; set; } 
 
        public string cus_status { get; set; } 
 
        public string shop_id { get; set; } 
 
        public int loginFailCount { get; set; } 
 
        public DateTime LastLoginTime { get; set; } 
 
        public string Status { get; set; } 
 
        public string PasswordSalt { get; set; } 
 
        public string NPassword { get; set; } 
 
        public string Userlp { get; set; } 
    }
    public class cus_yitian
    { 
        public string USERID { get; set; } 
 
        public string PWD { get; set; } 
 
        public string CUS_NAME { get; set; } 
 
        public string PHONE { get; set; } 
 
        public string PROVINCE { get; set; } 
 
        public string CITY { get; set; } 
 
        public string COUNTRY { get; set; } 
 
        public string TOWN { get; set; } 
 
        public string ADDRESS { get; set; } 
 
        public string REPAIRTYPE { get; set; } 
 
        public string COOPERATION { get; set; } 
 
        public DateTime SUBMITTIME { get; set; } 
 
        public string CNT { get; set; } 
    }
    public class customer
    { 
        public string C_Account { get; set; } 
 
        public string C_Password { get; set; } 
 
        public int C_Level { get; set; } 
 
        public string C_Nickname { get; set; } 
    }
    public class cxk_user
    { 
        public string CU_WorkNO { get; set; } 
 
        public string CU_Name { get; set; } 
 
        public Boolean CU_Sex { get; set; } 
 
        public string CU_Area { get; set; } 
 
        public string CU_Department { get; set; } 
 
        public int CU_CurDay { get; set; } 
 
        public int CU_DaySub { get; set; } 
 
        public int CU_CurMon { get; set; } 
 
        public int CU_MonSub { get; set; } 
 
        public int CU_CurYear { get; set; } 
 
        public int CU_YearSub { get; set; } 
 
        public int CU_TTLNum { get; set; } 
 
        public string CU_QRSceneVal { get; set; } 
 
        public string CU_QRCUrl { get; set; } 
 
        public string CU_Ticket { get; set; } 
    }
    public class e_module_t
    { 
        public string MODULE_DESC { get; set; } 
 
        public string MODULE_URL { get; set; } 
 
        public int MODULE_LEVEL { get; set; } 
 
        public int PARENT_MODULE_ID { get; set; } 
 
        public int MODULE_ORDER { get; set; } 
 
        public string LAST_EDIT_BY { get; set; } 
 
        public DateTime LAST_EDIT_DATE { get; set; } 
 
        public int MODULE_TYPE { get; set; } 
 
        public string DEL_FLAG { get; set; } 
    }
    public class e_role_module_t
    { 
        public int MODULE_ID { get; set; } 
 
        public string DEL_FLAG { get; set; } 
    }
    public class e_role_t
    { 
        public string ROLE_DESC { get; set; } 
 
        public string DEL_FLAG { get; set; } 
    }
    public class e_user_t
    { 
        public string USER_NAME { get; set; } 
 
        public string USER_PASSWORD { get; set; } 
 
        public int ROLE_ID { get; set; } 
 
        public int DEL_FLAG { get; set; } 
 
        public int DEPT_ID { get; set; } 
 
        public int LOGINFAILCOUNT { get; set; } 
 
        public DateTime LASTLOGINTIME { get; set; } 
    }
    public class fans_info
    { 
        public string FI_Openid { get; set; } 
 
        public int FI_SubCreateTime { get; set; } 
 
        public int FI_RtSubTimes { get; set; } 
 
        public decimal FI_Longitude { get; set; } 
 
        public decimal FI_Latitude { get; set; } 
 
        public Boolean FI_IsUnsub { get; set; } 
 
        public int FI_UnsubCreateTime { get; set; } 
 
        public int FI_RtUnsubTimes { get; set; } 
 
        public Boolean FI_IsQrc { get; set; } 
 
        public int FI_Cuid { get; set; } 
    }
    public class fans_rtsub
    { 
        public int FRS_CurDay { get; set; } 
 
        public int FRS_DaySub { get; set; } 
 
        public int FRS_CurMon { get; set; } 
 
        public int FRS_MonSub { get; set; } 
 
        public int FRS_CurYear { get; set; } 
 
        public int FRS_YearSub { get; set; } 
 
        public int FRS_TTLSub { get; set; } 
    }
    public class fans_rtunsub
    { 
        public int FRU_CurDay { get; set; } 
 
        public int FRU_DayUnsub { get; set; } 
 
        public int FRU_CurMon { get; set; } 
 
        public int FRU_MonUnsub { get; set; } 
 
        public int FRU_CurYear { get; set; } 
 
        public int FRU_YearUnsub { get; set; } 
 
        public int FRU_TTLUnsub { get; set; } 
    }
    public class materiel_unit
    { 
        public string Detail { get; set; } 
    }
    public class merchant_applylist
    { 
        public string mershop_name { get; set; } 
 
        public string merman_name { get; set; } 
 
        public string merman_phone { get; set; } 
 
        public string maincontents { get; set; } 
 
        public string province { get; set; } 
 
        public string city { get; set; } 
 
        public string country { get; set; } 
 
        public string town { get; set; } 
 
        public string address { get; set; } 
 
        public decimal lgt { get; set; } 
 
        public decimal lat { get; set; } 
 
        public string store_img { get; set; } 
 
        public string business_license { get; set; } 
 
        public string identity_card { get; set; } 
 
        public string mer_type { get; set; } 
    }
    public class msgrecord
    { 
        public int V_ID { get; set; } 
 
        public DateTime MR_Sendtime { get; set; } 
 
        public DateTime MR_Replytime { get; set; } 
 
        public string MR_Content { get; set; } 
 
        public Boolean MR_IsHisMsg { get; set; } 
 
        public string MR_FromUser { get; set; } 
    }
    public class order_relationship_t
    { 
        public DateTime ORDER_DATE { get; set; } 
 
        public string SHOP_ID { get; set; } 
 
        public string MERCHANT { get; set; } 
 
        public string SHOP_ORDER_NO { get; set; } 
 
        public string SETTLEMENT_NO { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public string SLT_STATUS { get; set; } 
    }
    public class productinfo
    { 
        public string type { get; set; } 
 
        public string brand { get; set; } 
 
        public string model { get; set; } 
 
        public DateTime onlineTime { get; set; } 
 
        public int onlinePrice { get; set; } 
 
        public int nowPrice { get; set; } 
 
        public DateTime updateTime { get; set; } 
    }
    public class quick_repairlist
    { 
        public string Repair_IMG { get; set; } 
 
        public decimal Repair_Price { get; set; } 
 
        public string Repair_Brand { get; set; } 
 
        public string Repair_Model { get; set; } 
 
        public string Repair_ErrType { get; set; } 
 
        public string Repair_ErrItem { get; set; } 
 
        public string Repair_Type { get; set; } 
    }
    public class quickcycle_orderlist
    { 
        public string quickrecycle_cusname { get; set; } 
 
        public string quickrecycle_cusphone { get; set; } 
 
        public string quickrecycle_cusmsg { get; set; } 
 
        public DateTime quickrecycle_time { get; set; } 
 
        public string quickrecycle_handresult { get; set; } 
 
        public string quickrecycle_handtime { get; set; } 
 
        public string quickRecycle_handleTime { get; set; } 
 
        public string quickRecycle_handerName { get; set; } 
    }
    public class quickrepair_orderlist
    { 
        public string quickrepair_cusname { get; set; } 
 
        public string quickrepair_cusphone { get; set; } 
 
        public string quickrepair_cusmeg { get; set; } 
 
        public DateTime quickrepair_custime { get; set; } 
 
        public string quickrepair_handleresult { get; set; } 
 
        public string quickrepair_handletime { get; set; } 
 
        public string quickrepair_handlename { get; set; } 
 
        public string quickrepair_failremark { get; set; } 
    }
    public class region_t
    { 
        public string PROVINCE { get; set; } 
 
        public string DEL_FLAG { get; set; } 
    }
    public class repair_engeographicalposition
    { 
        public string engineer_Id { get; set; } 
 
        public string engineer_Longtitude { get; set; } 
 
        public string engineer_Latitude { get; set; } 
 
        public string remark { get; set; } 
    }
    public class repair_engineerlist
    { 
        public string engineer_Id { get; set; } 
 
        public string engineer_Name { get; set; } 
 
        public string engineer_Contact { get; set; } 
 
        public string engineer_Province { get; set; } 
 
        public string engineer_City { get; set; } 
 
        public string engineer_County { get; set; } 
 
        public string engineer_Town { get; set; } 
 
        public string engineer_Address { get; set; } 
 
        public string open_Id { get; set; } 
 
        public string engineer_IdentityCard { get; set; } 
 
        public string repair_Type { get; set; } 
 
        public string repair_Item { get; set; } 
 
        public string repair_Area { get; set; } 
 
        public string del_flag { get; set; } 
    }
    public class repair_pricelist
    { 
        public string pro_Type { get; set; } 
 
        public string pro_Brand { get; set; } 
 
        public string pro_Model { get; set; } 
 
        public string err_Type { get; set; } 
 
        public string err_Item { get; set; } 
 
        public string re_Price { get; set; } 
 
        public int forder { get; set; } 
    }
    public class repair_repairinfolist
    { 
        public string re_OrderId { get; set; } 
 
        public string re_User_Name { get; set; } 
 
        public string re_User_PhoneNum { get; set; } 
 
        public string re_User_Province { get; set; } 
 
        public string re_User_City { get; set; } 
 
        public string re_User_County { get; set; } 
 
        public string re_User_Town { get; set; } 
 
        public string re_User_Address { get; set; } 
 
        public string re_Pro_Type { get; set; } 
 
        public string re_Pro_Brand { get; set; } 
 
        public string re_Pro_Model { get; set; } 
 
        public string re_PayType { get; set; } 
 
        public string re_PayState { get; set; } 
 
        public string re_IsNeedReceipt { get; set; } 
 
        public string re_TurnonOrNot { get; set; } 
 
        public string re_RepairHistory { get; set; } 
 
        public string re_RepairType { get; set; } 
 
        public string re_RepairReceiveType { get; set; } 
 
        public string re_SubmitTime { get; set; } 
 
        public string order_type { get; set; } 
 
        public DateTime payed_date { get; set; } 
 
        public string Shop_Id { get; set; } 
    }
    public class repair_repairinfolist_bak
    { 
        public string re_OrderId { get; set; } 
 
        public string re_User_Name { get; set; } 
 
        public string re_User_PhoneNum { get; set; } 
 
        public string re_User_Province { get; set; } 
 
        public string re_User_City { get; set; } 
 
        public string re_User_County { get; set; } 
 
        public string re_User_Town { get; set; } 
 
        public string re_User_Address { get; set; } 
 
        public string re_Pro_Type { get; set; } 
 
        public string re_Pro_Brand { get; set; } 
 
        public string re_Pro_Model { get; set; } 
 
        public string re_PayType { get; set; } 
 
        public string re_PayState { get; set; } 
 
        public string re_IsNeedReceipt { get; set; } 
 
        public string re_TurnonOrNot { get; set; } 
 
        public string re_RepairHistory { get; set; } 
 
        public string re_RepairType { get; set; } 
 
        public string re_RepairReceiveType { get; set; } 
 
        public string re_SubmitTime { get; set; } 
    }
    public class repair_repairlistclose
    { 
        public string re_OrderId { get; set; } 
 
        public string re_User_Name { get; set; } 
 
        public string re_User_Phone { get; set; } 
 
        public string re_User_Address { get; set; } 
 
        public string re_ProInfo { get; set; } 
 
        public string re_ErrInfo { get; set; } 
 
        public string re_Price { get; set; } 
 
        public string re_Pay_Type { get; set; } 
 
        public string re_Pay_State { get; set; } 
 
        public string re_IsNeedReceipt { get; set; } 
 
        public string re_RepairType { get; set; } 
 
        public string re_RepairReceiveType { get; set; } 
 
        public string re_SubmitTime { get; set; } 
 
        public string re_Status { get; set; } 
 
        public string re_OperaterName { get; set; } 
 
        public string re_CloseReseaon { get; set; } 
 
        public string re_Cus_StroeName { get; set; } 
 
        public string Order_Type { get; set; } 
 
        public string Shop_Id { get; set; } 
    }
    public class repair_repairlisterrinfo
    { 
        public string order_Id { get; set; } 
 
        public string re_Err_Type { get; set; } 
 
        public string re_Err_Item { get; set; } 
 
        public string re_Err_Info { get; set; } 
 
        public decimal re_Price { get; set; } 
 
        public string pre_Price { get; set; } 
    }
    public class repair_repairlistfinished
    { 
        public string re_OrderId { get; set; } 
 
        public string re_User_Name { get; set; } 
 
        public string re_User_PhoneNum { get; set; } 
 
        public string re_User_Province { get; set; } 
 
        public string re_User_City { get; set; } 
 
        public string re_User_County { get; set; } 
 
        public string re_User_Town { get; set; } 
 
        public string re_User_Address { get; set; } 
 
        public string re_Pro_Type { get; set; } 
 
        public string re_Pro_Brand { get; set; } 
 
        public string re_Pro_Model { get; set; } 
 
        public string re_Err_Type { get; set; } 
 
        public string re_Err_Item { get; set; } 
 
        public string re_Err_Info { get; set; } 
 
        public string re_Price { get; set; } 
 
        public string re_Pay_Type { get; set; } 
 
        public string re_Pay_Status { get; set; } 
 
        public string re_IsNeedReceipt { get; set; } 
 
        public string re_TurnonOrNot { get; set; } 
 
        public string re_RepairHistory { get; set; } 
 
        public string re_RepairType { get; set; } 
 
        public string re_RepairReceiveType { get; set; } 
 
        public string re_User_SubmitTime { get; set; } 
 
        public string re_Cus_FixedReceiveTime { get; set; } 
 
        public string re_Cus_FixedDetectTime { get; set; } 
 
        public string re_User_FixedRepairTime { get; set; } 
 
        public string re_Cus_CompleteRepairTime { get; set; } 
 
        public string re_Cus_FixedRepairTestTime { get; set; } 
 
        public string re_User_FixedPayTime { get; set; } 
 
        public string re_Cus_SubmitRepairTime { get; set; } 
 
        public string re_User_FixedReceiveTime { get; set; } 
 
        public string re_User_CommentTime { get; set; } 
 
        public int re_User_EveluateGrade_FuWuTaiDu { get; set; } 
 
        public int re_User_EveluateGrade_ZhuanYeJiNeng { get; set; } 
 
        public int re_User_EveluateGrade_WuLiuFuWu { get; set; } 
 
        public string re_User_CommentInfo { get; set; } 
 
        public string re_Cus_StoreName { get; set; } 
 
        public string Order_Type { get; set; } 
 
        public string Shop_Id { get; set; } 
 
        public int re_User_EveluateGrade_JiaGe { get; set; } 
    }
    public class repair_repairlistfinished2
    { 
        public string re_OrderId { get; set; } 
 
        public string re_User_Name { get; set; } 
 
        public string re_User_PhoneNum { get; set; } 
 
        public string re_User_Province { get; set; } 
 
        public string re_User_City { get; set; } 
 
        public string re_User_County { get; set; } 
 
        public string re_User_Town { get; set; } 
 
        public string re_User_Address { get; set; } 
 
        public string re_Pro_Type { get; set; } 
 
        public string re_Pro_Brand { get; set; } 
 
        public string re_Pro_Model { get; set; } 
 
        public string re_Err_Type { get; set; } 
 
        public string re_Err_Item { get; set; } 
 
        public string re_Err_Info { get; set; } 
 
        public string re_Price { get; set; } 
 
        public string re_Pay_Type { get; set; } 
 
        public string re_Pay_Status { get; set; } 
 
        public string re_IsNeedReceipt { get; set; } 
 
        public string re_TurnonOrNot { get; set; } 
 
        public string re_RepairHistory { get; set; } 
 
        public string re_RepairType { get; set; } 
 
        public string re_RepairReceiveType { get; set; } 
 
        public string re_User_SubmitTime { get; set; } 
 
        public string re_Cus_FixedReceiveTime { get; set; } 
 
        public string re_Cus_FixedDetectTime { get; set; } 
 
        public string re_User_FixedRepairTime { get; set; } 
 
        public string re_Cus_CompleteRepairTime { get; set; } 
 
        public string re_Cus_FixedRepairTestTime { get; set; } 
 
        public string re_User_FixedPayTime { get; set; } 
 
        public string re_Cus_SubmitRepairTime { get; set; } 
 
        public string re_User_FixedReceiveTime { get; set; } 
 
        public string re_User_CommentTime { get; set; } 
 
        public int re_User_EveluateGrade_FuWuTaiDu { get; set; } 
 
        public int re_User_EveluateGrade_ZhuanYeJiNeng { get; set; } 
 
        public int re_User_EveluateGrade_WuLiuFuWu { get; set; } 
 
        public string re_User_CommentInfo { get; set; } 
 
        public string re_Cus_StoreName { get; set; } 
 
        public string open_id { get; set; } 
 
        public string Order_Type { get; set; } 
 
        public string Shop_Id { get; set; } 
 
        public string del_flag { get; set; } 
 
        public int re_User_EveluateGrade_JiaGe { get; set; } 
    }
    public class repair_repairlistfinished3
    { 
        public string re_OrderId { get; set; } 
 
        public string re_User_Name { get; set; } 
 
        public string re_User_PhoneNum { get; set; } 
 
        public string re_User_Province { get; set; } 
 
        public string re_User_City { get; set; } 
 
        public string re_User_County { get; set; } 
 
        public string re_User_Town { get; set; } 
 
        public string re_User_Address { get; set; } 
 
        public string re_Pro_Type { get; set; } 
 
        public string re_Pro_Brand { get; set; } 
 
        public string re_Pro_Model { get; set; } 
 
        public string re_Err_Type { get; set; } 
 
        public string re_Err_Item { get; set; } 
 
        public string re_Err_Info { get; set; } 
 
        public string re_Price { get; set; } 
 
        public string re_Pay_Type { get; set; } 
 
        public string re_Pay_Status { get; set; } 
 
        public string re_IsNeedReceipt { get; set; } 
 
        public string re_TurnonOrNot { get; set; } 
 
        public string re_RepairHistory { get; set; } 
 
        public string re_RepairType { get; set; } 
 
        public string re_RepairReceiveType { get; set; } 
 
        public string re_User_SubmitTime { get; set; } 
 
        public string re_Cus_FixedReceiveTime { get; set; } 
 
        public string re_Cus_FixedDetectTime { get; set; } 
 
        public string re_User_FixedRepairTime { get; set; } 
 
        public string re_Cus_CompleteRepairTime { get; set; } 
 
        public string re_Cus_FixedRepairTestTime { get; set; } 
 
        public string re_User_FixedPayTime { get; set; } 
 
        public string re_Cus_SubmitRepairTime { get; set; } 
 
        public string re_User_FixedReceiveTime { get; set; } 
 
        public string re_User_CommentTime { get; set; } 
 
        public int re_User_EveluateGrade_FuWuTaiDu { get; set; } 
 
        public int re_User_EveluateGrade_ZhuanYeJiNeng { get; set; } 
 
        public int re_User_EveluateGrade_WuLiuFuWu { get; set; } 
 
        public string re_User_CommentInfo { get; set; } 
 
        public string Order_Type { get; set; } 
 
        public string Shop_Id { get; set; } 
 
        public int re_User_EveluateGrade_JiaGe { get; set; } 
    }
    public class repair_repairliststate
    { 
        public string re_OrderId { get; set; } 
 
        public string re_State { get; set; } 
 
        public string re_User_SubmitTime { get; set; } 
 
        public string re_Cus_FixedReceiveTime { get; set; } 
 
        public string re_Cus_FixedDetectTime { get; set; } 
 
        public string re_User_FixedRepairTime { get; set; } 
 
        public string re_Cus_CompleteRepairTime { get; set; } 
 
        public string re_Cus_FixedRepairTestTime { get; set; } 
 
        public string re_User_FixedPayTime { get; set; } 
 
        public string re_Cus_SubmitRepairTime { get; set; } 
 
        public string re_User_FixedReceiveTime { get; set; } 
 
        public string re_User_CommentTime { get; set; } 
 
        public string cus_storeName { get; set; } 
 
        public string cus_storeId { get; set; } 
 
        public string shop_id { get; set; } 
 
        public string order_type { get; set; } 
    }
    public class repair_sendcode
    { 
        public string re_code { get; set; } 
 
        public DateTime create_date { get; set; } 
 
        public string send_status { get; set; } 
 
        public string send_mess { get; set; } 
    }
    public class repair_shopaddresslist_new
    { 
        public string shop_name { get; set; } 
 
        public string shop_address { get; set; } 
 
        public string shop_contact { get; set; } 
 
        public string province { get; set; } 
 
        public string city { get; set; } 
 
        public decimal del_flag { get; set; } 
 
        public string shop_type { get; set; } 
 
        public string shop_legalperson { get; set; } 
 
        public string shop_email { get; set; } 
 
        public int shop_size { get; set; } 
 
        public string shop_certificate { get; set; } 
 
        public string cus_identityCard { get; set; } 
 
        public string cus_AccountNo { get; set; } 
 
        public string cus_paytype { get; set; } 
 
        public string shop_introduce { get; set; } 
 
        public string shop_id { get; set; } 
 
        public string shop_status { get; set; } 
 
        public DateTime create_date { get; set; } 
 
        public int cal_id { get; set; } 
 
        public decimal paybail_total { get; set; } 
    }
    public class repair_temp_t
    {    }
    public class self_bom
    { 
        public string Bom_ShopID { get; set; } 
 
        public string Bom_Type { get; set; } 
 
        public string Bom_Category { get; set; } 
 
        public string Bom_Name { get; set; } 
 
        public string Bom_Brand { get; set; } 
 
        public string Bom_Model { get; set; } 
 
        public string Bom_Specification { get; set; } 
 
        public string Bom_Parameter { get; set; } 
 
        public string Bom_Remark { get; set; } 
 
        public string Bom_Date { get; set; } 
 
        public string Bom_B { get; set; } 
 
        public string Bom_A { get; set; } 
    }
    public class sendmsgcount
    {    }
    public class settlement_exception_list_t
    { 
        public string SHOP_ID { get; set; } 
 
        public string MERCHANT { get; set; } 
 
        public DateTime SETTLEMENT_SDATE { get; set; } 
 
        public DateTime SETTLEMENT_EDATE { get; set; } 
 
        public string SETTLEMENT_WAY { get; set; } 
 
        public string SHOP_PERSON { get; set; } 
 
        public string ACCOUNT_NO { get; set; } 
 
        public int ORDER_QTY { get; set; } 
 
        public decimal SETTLEMENT_AMOUNT { get; set; } 
 
        public decimal COMMISSION_AMOUNT { get; set; } 
 
        public decimal ACTUAL_AMOUNT { get; set; } 
 
        public decimal ADD_SUBTRACT_AMOUNT { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public string REGION { get; set; } 
 
        public string ID_CARD { get; set; } 
 
        public decimal BOND_AMOUNT { get; set; } 
 
        public decimal FINAL_AMOUNT { get; set; } 
 
        public string EXCEPTION_DESC { get; set; } 
 
        public string RESULT { get; set; } 
 
        public string AGAIN_TYPE { get; set; } 
    }
    public class settlement_item_t
    { 
        public DateTime ORDER_DATE { get; set; } 
 
        public string SHOP_ID { get; set; } 
 
        public string SHOP_PERSON { get; set; } 
 
        public string SETTLEMENT_WAY { get; set; } 
 
        public string ACCOUNT_NO { get; set; } 
 
        public string ORDER_TYPE { get; set; } 
 
        public DateTime SETTLEMENT_DATE { get; set; } 
 
        public string MERCHANT { get; set; } 
 
        public string CHARGE_WAY { get; set; } 
 
        public decimal MAINTENANCE_COSTS { get; set; } 
 
        public string COST_STATUS { get; set; } 
 
        public decimal POUNDAGE_RATIO { get; set; } 
 
        public decimal DEBIT_AMOUNT { get; set; } 
 
        public decimal COMMISSION_RATE { get; set; } 
 
        public string COMMISSION_CODE { get; set; } 
 
        public decimal COMMISSION_AMOUNT { get; set; } 
 
        public decimal ACTUAL_AMOUNT { get; set; } 
 
        public decimal BOND_RATE { get; set; } 
 
        public decimal BOND_AMOUNT { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public string REGION { get; set; } 
 
        public string MERCHANT_CATEGORY { get; set; } 
 
        public int SLI_ID { get; set; } 
 
        public string SLI_STATUS { get; set; } 
 
        public decimal WEIXIN_COSTS { get; set; } 
    }
    public class settlement_list_t
    { 
        public string MERCHANT { get; set; } 
 
        public DateTime SETTLEMENT_SDATE { get; set; } 
 
        public DateTime SETTLEMENT_EDATE { get; set; } 
 
        public string SETTLEMENT_WAY { get; set; } 
 
        public string SHOP_PERSON { get; set; } 
 
        public string ACCOUNT_NO { get; set; } 
 
        public int ORDER_QTY { get; set; } 
 
        public decimal SETTLEMENT_AMOUNT { get; set; } 
 
        public decimal COMMISSION_AMOUNT { get; set; } 
 
        public decimal ACTUAL_AMOUNT { get; set; } 
 
        public decimal ADD_SUBTRACT_AMOUNT { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public int SLT_ID { get; set; } 
 
        public string SLT_STATUS { get; set; } 
 
        public string SLT_ORDERNO { get; set; } 
 
        public string SLT_SETTLEMENT_NO { get; set; } 
 
        public string REGION { get; set; } 
 
        public string ID_CARD { get; set; } 
 
        public decimal BOND_AMOUNT { get; set; } 
 
        public decimal FINAL_AMOUNT { get; set; } 
    }
    public class settlement_pay_list_t
    { 
        public string SHOPID { get; set; } 
 
        public string PARTNER__TRADE_NO { get; set; } 
 
        public string PAYMENT_NO { get; set; } 
 
        public string PAYMENT_TIME { get; set; } 
 
        public string RETURN_CODE { get; set; } 
 
        public string RETURN_MESS { get; set; } 
 
        public string RESULT_CODE { get; set; } 
 
        public string ERR_CODE { get; set; } 
 
        public string ERR_CODE_DES { get; set; } 
 
        public string PAY_FEE { get; set; } 
 
        public string CREATER_USER { get; set; } 
 
        public string CREATER_USER_IP { get; set; } 
 
        public DateTime CREATER_TIME { get; set; } 
 
        public string OPEN_ID { get; set; } 
 
        public string USER_NAME { get; set; } 
    }
    public class settlement_summary_t
    { 
        public DateTime SETTLEMENT_SDATE { get; set; } 
 
        public DateTime SETTLEMENT_EDATE { get; set; } 
 
        public int MERCHANT_QTY { get; set; } 
 
        public string OPERATOR_BY { get; set; } 
 
        public decimal SETTLEMENT_AMOUNT { get; set; } 
 
        public decimal COMMISSION_AMOUNT { get; set; } 
 
        public decimal ACTUAL_AMOUNT { get; set; } 
 
        public string SETTLEMENTNO_STATUS { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public DateTime SETTLEMENT_DATE { get; set; } 
 
        public int SLS_ID { get; set; } 
 
        public decimal FINAL_AMOUNT { get; set; } 
 
        public decimal BOND_AMOUNT { get; set; } 
 
        public decimal ADD_AMOUNT { get; set; } 
    }
    public class shop_commission_t
    { 
        public string ORDER_TYPE { get; set; } 
 
        public int COMMI_ID { get; set; } 
 
        public string CREATE_BY { get; set; } 
 
        public DateTime CREATE_DATE { get; set; } 
 
        public string LAST_EDIT_BY { get; set; } 
 
        public DateTime LAST_EDIT_DT { get; set; } 
 
        public string DEL_FLAG { get; set; } 
    }
    public class shop_receipts_t
    { 
        public string RECEIPTS_TYPE { get; set; } 
 
        public string RECEIPTS_ACCOUNT { get; set; } 
 
        public string RECEIPTS_PERSON { get; set; } 
 
        public string RECEIPTS_INFO { get; set; } 
 
        public string ACCOUNT_STATE { get; set; } 
 
        public string CREATE_BY { get; set; } 
 
        public DateTime CREATE_DATE { get; set; } 
 
        public string LAST_EDIT_BY { get; set; } 
 
        public DateTime LAST_EDIT_DT { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public int SC_ID { get; set; } 
    }
    public class shopbail_pay_t
    { 
        public string SETTLEMENT_NO { get; set; } 
 
        public decimal SETTLEMENT_AMOUNT { get; set; } 
 
        public decimal PAYBAIL_RATE { get; set; } 
 
        public decimal PAYBAIL { get; set; } 
 
        public decimal NEEDBAIL { get; set; } 
 
        public string CREATE_BY { get; set; } 
 
        public DateTime CREATE_DATE { get; set; } 
 
        public string DEL_DESC { get; set; } 
 
        public string DEL_FLAG { get; set; } 
    }
    public class sms_sendstatus
    { 
        public string name { get; set; } 
 
        public string phone { get; set; } 
 
        public string order_Id { get; set; } 
 
        public string status { get; set; } 
 
        public DateTime time { get; set; } 
    }
    public class stock_check
    { 
        public string Stock_Code { get; set; } 
 
        public int AccCount { get; set; } 
 
        public int CheckCount { get; set; } 
 
        public decimal DiffAmount { get; set; } 
 
        public DateTime CheckTime { get; set; } 
 
        public string CheckA { get; set; } 
 
        public string CheckB { get; set; } 
    }
    public class stock_details
    { 
        public string Stock_Code { get; set; } 
 
        public string Type { get; set; } 
 
        public string OrderNum { get; set; } 
 
        public int Count { get; set; } 
 
        public int Stock_Unit { get; set; } 
 
        public decimal UnitPrice { get; set; } 
 
        public string CreateTime { get; set; } 
    }
    public class stock_infolist
    { 
        public string Stock_ShopID { get; set; } 
 
        public string Stock_Sn { get; set; } 
 
        public string Stock_ProviderID { get; set; } 
 
        public int Stock_Amount { get; set; } 
 
        public int Stock_Unit { get; set; } 
 
        public decimal Stock_Univalent { get; set; } 
 
        public decimal SuggestedPrice { get; set; } 
 
        public int Stock_WarningCount { get; set; } 
 
        public int Stock_DullCount { get; set; } 
 
        public DateTime Stock_LastButOneUpdate { get; set; } 
 
        public DateTime Stock_LastTimeUpdate { get; set; } 
    }
    public class sys_commission_t
    { 
        public string COMMISSION_CODE { get; set; } 
 
        public decimal COMMISSION_RATE { get; set; } 
 
        public string COMMISSION_DESC { get; set; } 
 
        public string CREATE_BY { get; set; } 
 
        public DateTime CREATE_DATE { get; set; } 
 
        public string LAST_EDIT_BY { get; set; } 
 
        public DateTime LAST_EDIT_DT { get; set; } 
 
        public string DEL_FLAG { get; set; } 
 
        public decimal PAYBAIL_RATE { get; set; } 
 
        public int BAIL_TOTAL { get; set; } 
    }
    public class sys_menu
    { 
        public string SM_Name { get; set; } 
 
        public string SM_Path { get; set; } 
 
        public string SM_SmallImage { get; set; } 
 
        public string SM_BigImage { get; set; } 
 
        public string SM_Shortcut { get; set; } 
 
        public int SM_DisplayIndex { get; set; } 
 
        public string SM_GroupName { get; set; } 
 
        public string SM_IsDisplay { get; set; } 
 
        public string SM_Note { get; set; } 
 
        public int SM_PID { get; set; } 
 
        public string SM_NotModule { get; set; } 
    }
    public class sys_organization
    { 
        public string SO_NO { get; set; } 
 
        public string SO_Name { get; set; } 
 
        public int SO_PID { get; set; } 
 
        public string SO_Type { get; set; } 
 
        public string SO_Note { get; set; } 
    }
    public class sys_power
    { 
        public int SR_ID { get; set; } 
 
        public int SM_ID { get; set; } 
 
        public int SP_OperatorPower { get; set; } 
 
        public string SP_Note { get; set; } 
    }
    public class sys_role
    { 
        public string SR_Name { get; set; } 
 
        public string SR_ProhibitModule { get; set; } 
 
        public string SR_Note { get; set; } 
    }
    public class sys_user
    { 
        public int SO_ID { get; set; } 
 
        public string SU_LoginAccount { get; set; } 
 
        public string SU_LoginPassword { get; set; } 
 
        public string SU_WorkNo { get; set; } 
 
        public string SU_RealName { get; set; } 
 
        public Boolean SU_Sex { get; set; } 
 
        public string SU_Status { get; set; } 
 
        public DateTime SU_LastLoginTime { get; set; } 
 
        public DateTime SU_RegisterTime { get; set; } 
 
        public string SU_LoginNumber { get; set; } 
 
        public Boolean SU_IsActive { get; set; } 
 
        public string SU_ProhibitPower { get; set; } 
 
        public string SU_AllowPower { get; set; } 
 
        public string SU_Note { get; set; } 
    }
    public class sys_user_operate_log_t
    { 
        public string OPERATE_TYPE { get; set; } 
 
        public string OPERATE_URL { get; set; } 
 
        public string OPERATE_USER { get; set; } 
 
        public string OPERATE_IP { get; set; } 
 
        public DateTime OPERATE_TIME { get; set; } 
 
        public string OPERATE_REMARK { get; set; } 
    }
    public class sys_userrole
    { 
        public int SR_ID { get; set; } 
 
        public int SU_ID { get; set; } 
 
        public string SUR_Note { get; set; } 
    }
    public class timespaninfo
    { 
        public int tijiao { get; set; } 
 
        public int qianshou { get; set; } 
 
        public int jiance { get; set; } 
 
        public int queren { get; set; } 
 
        public int weixiu { get; set; } 
 
        public int ceshi { get; set; } 
 
        public int zhifu { get; set; } 
 
        public int fahuo { get; set; } 
 
        public int shouhuo { get; set; } 
 
        public int pinglun { get; set; } 
    }
    public class user_history
    { 
        public int CU_ID { get; set; } 
 
        public int UH_Day { get; set; } 
 
        public int UH_DaySub { get; set; } 
 
        public int UH_Mon { get; set; } 
 
        public int UH_MonSub { get; set; } 
 
        public int UH_Year { get; set; } 
 
        public int UH_YearSub { get; set; } 
 
        public int UH_TTLSum { get; set; } 
    }
    public class users_advice
    { 
        public string user_Name { get; set; } 
 
        public string user_PhoneNum { get; set; } 
 
        public string advice { get; set; } 
 
        public string advice_Time { get; set; } 
 
        public string advice_Status { get; set; } 
    }
    public class visitor
    { 
        public int C_ID { get; set; } 
 
        public string V_Openid { get; set; } 
 
        public string V_Nickname { get; set; } 
 
        public string V_Headimg { get; set; } 
 
        public Boolean V_IsOnline { get; set; } 
 
        public DateTime V_Creattime { get; set; } 
    }
    public class we_chat_users_info
    { 
        public string u_Pwd { get; set; } 
 
        public string name { get; set; } 
 
        public string phone { get; set; } 
 
        public string role { get; set; } 
 
        public DateTime createTime { get; set; } 
    }
    public class wechat_comment_usr_info
    { 
        public string order_id { get; set; } 
 
        public string user_name { get; set; } 
 
        public string user_img { get; set; } 
 
        public DateTime create_date { get; set; } 
 
        public DateTime edit_date { get; set; } 
 
        public string del_flag { get; set; } 
    }
    public class wechat_forum_post
    { 
        public string plate { get; set; } 
 
        public string title { get; set; } 
 
        public string count { get; set; } 
 
        public string time { get; set; } 
 
        public string author { get; set; } 
 
        public string img { get; set; } 
 
        public int forum_scan { get; set; } 
 
        public int forum_reply { get; set; } 
    }
    public class wechat_forum_reply
    { 
        public string theme { get; set; } 
 
        public string count { get; set; } 
 
        public string time { get; set; } 
 
        public string author { get; set; } 
 
        public string img { get; set; } 
    }
    public class wechat_news_comment
    { 
        public int n_id { get; set; } 
 
        public string type { get; set; } 
 
        public string r_id { get; set; } 
 
        public string author { get; set; } 
 
        public string text { get; set; } 
 
        public DateTime time { get; set; } 
 
        public int zanCount { get; set; } 
 
        public string author_img { get; set; } 
    }
    public class wechat_news_info
    { 
        public string type { get; set; } 
 
        public string title { get; set; } 
 
        public string author { get; set; } 
 
        public DateTime time { get; set; } 
 
        public string imgs { get; set; } 
 
        public string text { get; set; } 
 
        public int browseCount { get; set; } 
 
        public int commentCount { get; set; } 
 
        public int zanCount { get; set; } 
    }
    public class wechat_pay
    { 
        public string bank_type { get; set; } 
 
        public int cash_fee { get; set; } 
 
        public string fee_type { get; set; } 
 
        public string is_subscribe { get; set; } 
 
        public string mch_id { get; set; } 
 
        public string nonce_str { get; set; } 
 
        public string openid { get; set; } 
 
        public string out_trade_no { get; set; } 
 
        public string result_code { get; set; } 
 
        public string return_code { get; set; } 
 
        public string sign { get; set; } 
 
        public string time_end { get; set; } 
 
        public int total_fee { get; set; } 
 
        public string trade_type { get; set; } 
 
        public string transaction_id { get; set; } 
 
        public string pay_source { get; set; } 
 
        public string update_status { get; set; } 
    }
    public class wechat_payment_back_log_t
    { 
        public string BANK_TYPE { get; set; } 
 
        public string FEE_TYPE { get; set; } 
 
        public string MCH_ID { get; set; } 
 
        public string OPENID { get; set; } 
 
        public string OUT_TRADE_NO { get; set; } 
 
        public string RETURN_CODE { get; set; } 
 
        public string TIME_END { get; set; } 
 
        public int TOTAL_FEE { get; set; } 
 
        public string TRANSACTION_ID { get; set; } 
 
        public string PAY_SOURCE { get; set; } 
    }
    public class wechat_store_proinfo
    { 
        public string p_name { get; set; } 
 
        public string type { get; set; } 
 
        public string brand { get; set; } 
 
        public string model { get; set; } 
 
        public string error { get; set; } 
 
        public string info { get; set; } 
 
        public string sort { get; set; } 
 
        public string color { get; set; } 
 
        public string p_imgs { get; set; } 
 
        public string i_imgs { get; set; } 
 
        public string caption { get; set; } 
 
        public string price { get; set; } 
 
        public string discount { get; set; } 
 
        public int count { get; set; } 
 
        public int attentionCount { get; set; } 
 
        public int commentCount { get; set; } 
 
        public DateTime createTime { get; set; } 
 
        public DateTime updateTime { get; set; } 
 
        public string remarks { get; set; } 
    }
    public class wechat_users_info
    { 
        public string name { get; set; } 
 
        public string phone { get; set; } 
 
        public string role { get; set; } 
 
        public DateTime createTime { get; set; } 
 
        public string usr_img { get; set; } 
 
        public string usr_openid { get; set; } 
 
        public string nick_name { get; set; } 
    }
    public class yitianinfo
    { 
        public string COM_PHONE { get; set; } 
 
        public string COM_ADDRESS { get; set; } 
 
        public int COM_ID { get; set; } 
    }
}