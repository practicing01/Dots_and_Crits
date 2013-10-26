function Class_Deathball::Update_Health(%this,%Health)
{

%this.Health+=%Health;echo(%this.Health);

if (%this.Health<=0)
{

%this.Module_ID_Parent.Simset_Deathballs.remove(%this);

%this.safeDelete();

}

}
