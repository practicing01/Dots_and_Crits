function Class_NPC_Wyvern::Update_Health(%this)
{

if (%this.Health<=0&&%this.getBlendAlpha()!=0.5)
{

%this.setBlendAlpha(0.5);

%this.Module_ID_Parent.Simset_Objects.remove(%this);

schedule(2000,0,"Class_NPC_Wyvern::Safe_Delete",%this);

}

}
