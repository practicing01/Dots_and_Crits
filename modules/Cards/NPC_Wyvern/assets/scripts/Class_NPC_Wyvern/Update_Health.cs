function Class_NPC_Wyvern::Update_Health(%this)
{

if (%this.Health<=0&&%this.getBlendAlpha()!=0.5)
{

%this.setBlendAlpha(0.5);

%this.Animation_Set("Die");

%this.Module_ID_Parent.Simset_Objects.remove(%this);

schedule(2000,0,"Class_NPC_Wyvern::Safe_Delete",%this);

return;

}

if (%this.Previous_Health-%this.Health>=500)//Hit
{

%this.Previous_Health=%this.Health;

%this.Animation_Set("Hit");

}
else if (%this.Previous_Health<%this.Health)//Heal
{



}
else//No change
{



}

}
