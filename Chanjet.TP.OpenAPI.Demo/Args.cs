using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Chanjet.TP.OpenAPI.Demo
{
	public class Args
	{
		public string getFieldValue(string fieldName)
		{
			string arg = typeof(Args).GetField(fieldName).GetValue(this).ToString();
			arg = arg.Replace("2014-09-30", DateTime.Now.ToString("yyyy-MM-dd"));
			return arg;
		}

		public string Authorization = @"{AppKey:""myAppKey"",AppSecret:""myAppSecret"",UserName:""demo"",Password:"""",LoginDate:""2014-09-30"",AccountNumber:""1"",
ServerURL:""http://127.0.0.1/TPlus/api/v1/"",ServerURLItems:[""http://127.0.0.1/TPlus/api/v1/"",""http://demo.chanjet.com/TPlus116/api/v1/""]}";

		public string inventory_Query =
@"{
	param:{Code:""001""}
}";

		public string brand_Query =
@"{
	param:{Code:""001""}
}";

		public string freeItemType_Query =
@"{
	param:{}
}
";

		public string freeItem_Query =
@"{
	param:{ Type:""颜色""}
}";

		public string warehouse_Query =
@"{
	param:{Code:""001""}
}";

		public string barCode_Query =
@"{
	param:{BarCode:""001""}
}";
        public string voucherDraft_Query =
@"{
	param:{Name:""SaleOrder""}
}";
		public string saleDelivery_Create =
@"{
	dto:{
		VoucherDate: ""2014-09-30"",
		ExternalCode:""1"",
		Customer: {Code: ""001""}, 
		InvoiceType: {Code: ""01""},
		Address: ""xx省xx市"",
		LinkMan: ""张三"",
		ContactPhone: ""13611111111"",
		Memo: ""测试OpenAPI"",
		SaleDeliveryDetails: [{
			Inventory:{Code: ""001""},
			Unit: {Name:""个""},
			Quantity: 5, 
			OrigTaxAmount: 90
		}]
	} 
}
";


		public string saleDelivery_CreateBatch =
@"{
	dtos: [{
            VoucherDate: ""2014-09-30"",
            ExternalCode: ""2"",
            Customer: {Code: ""001""},
            InvoiceType: {Code: ""01""},
            Address: ""xx省xx市"",
            LinkMan: ""张三"",
            ContactPhone: ""13611111111"",
            Memo: ""测试OpenAPI"",
            SaleDeliveryDetails: [{
				Inventory:{Code: ""001""},
                Unit: {Name: ""个""},
                Quantity: 5, 
                OrigTaxAmount: 90
            }]
		},{
            VoucherDate: ""2014-09-30"",
            ExternalCode: ""3"",
            Customer: {Code: ""001""},
            InvoiceType: {Code: ""01""},
            Address: ""xx省xx市"",
            LinkMan: ""张三"",
            ContactPhone: ""13611111111"",
            Memo: ""测试OpenAPI"",
            SaleDeliveryDetails: [{
				Inventory:{Code: ""001""},
                Unit: {Name: ""个""},
                Quantity: 5, 
                OrigTaxAmount: 90
            }]
        }],
	param: {
			isAutoCreateMember: false,
			isPromotion: false
	}
}";


		public string otherDispatch_Create =
@"{
	dto:{
		ExternalCode: ""st0001"",
		VoucherType: {Code: ""ST1024""},
		VoucherDate: ""2014-09-30"",
		BusiType: {Code: ""13""},
		Warehouse: {Code: ""001""},
		Memo: ""测试"",
		RDRecordDetails: [{
			InvBarCode: """",
			Inventory: {Code: ""001""},
			BaseQuantity: 1.00
		}]
	}
}
";

		public string otherDispatch_CreateBatch =
@"{
	dtos:[{
		ExternalCode: ""st0002"",
		VoucherType: {Code: ""ST1024""},
		VoucherDate: ""2014-09-30"",
		BusiType: {Code: ""13""},
		Warehouse: {Code: ""001""},
		Memo: ""测试OpenAPI "",
		RDRecordDetails: [{
			InvBarCode: """",
			Inventory: {Code: ""001""},
			BaseQuantity: 1.00
		}]
	},{
		ExternalCode: ""st0003"",
		VoucherType: {Code: ""ST1024""},
		VoucherDate: ""2014-09-30"",
		BusiType: {Code: ""13""},
		Warehouse: {Code: ""001""},
		Memo: ""测试OpenAPI"",
		RDRecordDetails: [{
			InvBarCode: """",
			Inventory: {Code: ""001""},
			BaseQuantity: 1.00
		}]
	}]
	,param:{}
}";


		public string currentStock_Query =
@"{
	param:{
		Warehouse: [{Code:""001"" },{Code:""002"" }],
		InvBarCode: """",
		BeginInventoryCode: """",
		EndInventoryCode: """",
		InventoryName: """",
		Specification: """",
		Brand: """", 
		GroupInfo: {
			Warehouse: true,
			Inventory:  true,
			Brand:  true,
			InvProperty:  true
		}
	}
}";


		public string doc_Create =
@"{
	dto:{
		ExternalCode:""1"",
		DocType:{ Name:""记账凭证"",Code:""记""}, 
		VoucherDate:""2014-09-30"",
		Entrys:[{
			Summary:""提现"",
			Account:{Code:""1001""},
			Currency:{Code:""RMB""},
			AmountCr:""100""
		},{
			Summary:""提现"",
			Account:{Code:""1002""},
			Currency:{Code:""RMB""},
			AmountDr:""100"",
			AuxInfos:[{AuxAccDepartment:{Code:""bm01""}}]
		}] 
	}
} ";


		public string doc_CreateBatch =
@"{
	dtos:[{
		ExternalCode:""2"",
		DocType:{ Name:""记账凭证"",Code:""记""}, 
		VoucherDate:""2014-09-30"",
		Entrys:[{
			Summary:""提现"",
			Account:{Code:""1001""},
			Currency:{Code:""RMB""},
			AmountCr:""100""
		},{
			Summary:""提现"",
			Account:{Code:""1002""},
			Currency:{Code:""RMB""},
			AmountDr:""100"",
			AuxInfos:[{AuxAccDepartment:{Code:""bm01""}}]
		}] 
	},{
		ExternalCode:""3"",
		DocType:{ Name:""记账凭证"",Code:""记""}, 
		VoucherDate:""2014-09-30"",
		Entrys:[{
			Summary:""提现"",
			Account:{Code:""1001""},
			Currency:{Code:""RMB""},
			AmountCr:""100""
		},{
			Summary:""提现"",
			Account:{Code:""1002""},
			Currency:{Code:""RMB""},
			AmountDr:""100"",
			AuxInfos:[{AuxAccDepartment:{Code:""bm01""}}]
		}] 
	}],
	param:{}	 
}";


	}
}
