function Class_Mushroom::Update_Health(%this)
{

if (%this.Health<=0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

if (isObject(%this.Mounted_Rain_Drops))
{

%this.Module_ID_Parent.Simset_Objects.remove(%this.Mounted_Rain_Drops);

%this.Mounted_Rain_Drops.dismount();

%this.Mounted_Rain_Drops.safeDelete();

}

%this.safeDelete();

}

}
