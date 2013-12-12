function Class_Deus_Ex_Telum_Mech::Update_Health(%this,%Health)
{

%this.Health+=%Health;

if (%this.Health<=0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}
