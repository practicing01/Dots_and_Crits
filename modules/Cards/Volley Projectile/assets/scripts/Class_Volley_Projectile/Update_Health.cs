function Class_Volley_Projectile::Update_Health(%this,%Health)
{

%this.Health+=%Health;

if (%this.Health<=0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}