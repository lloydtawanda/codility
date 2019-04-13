<Query Kind="Program">
  <Reference>D:\Projects\AP\ActivationPortal\bin\Optiva.Dcrm.PromotionEngine.dll</Reference>
  <Reference>D:\Projects\AP\ActivationPortal\bin\Redknee.CRM.Common.dll</Reference>
  <Reference>D:\Projects\AP\ActivationPortal\bin\Site.dll</Reference>
  <Namespace>Optiva.Dcrm.PromotionEngine.Dto</Namespace>
  <Namespace>Redknee.CRM.Common</Namespace>
  <Namespace>Redknee.CRM.Common.Format</Namespace>
  <Namespace>Site.Controls.Promotions</Namespace>
</Query>

void Main()
{

	var bundles = new BundleMetadata[]{
	new BundleMetadata {
		Id= 1,
			TotalMrcs= 5,
			Name= "Promo Booster 100",
			InitialBalanceLimit= 6000,
			ConsumedBalance= 600,
			BundleType= BundleType.Voice,
			BundleUnitType= BundleUnitType.VolumeSeconds
		},
	new BundleMetadata{
			Id = 2,
			Name= "Promo Booster 50MB",
			InitialBalanceLimit= 5120000,
			ConsumedBalance= 10240,
			BundleType= BundleType.Data,
			BundleUnitType= BundleUnitType.VolumeKilobytes
		},
	new BundleMetadata{
			Id= 3,
			Name= "Promo Booster 100MB",
			InitialBalanceLimit= 5120000,
			ConsumedBalance= 10240,
			BundleType= BundleType.Data,
			BundleUnitType= BundleUnitType.VolumeKilobytes
		},
	new BundleMetadata{
		Id= 4,
		Name= "Promo Booster 500MB",
		InitialBalanceLimit= 5120000,
		ConsumedBalance= 0,
		BundleType= BundleType.Data,
		BundleUnitType= BundleUnitType.VolumeKilobytes
	}
	};

	foreach(var bundle in bundles)
	{
		bundle.Description = bundle.GetDescription();
	}

	bundles.Dump();
}

// Define other methods and classes here
