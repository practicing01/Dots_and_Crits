function Class_Bath_Salts_DWO::Update_Health(%this)
{

if (%this.Health<=0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}
