function Module_Card_Volley_Projectile::Card_Unload(%this)
{

%this.Ass_Unload();


if (isObject(%this.Vector_2D_Table))
{

%this.Vector_2D_Table.deleteObjects();

%this.Vector_2D_Table.delete();

}

%this.Simset_Objects.deleteObjects();

%this.Simset_Objects.delete();

}
