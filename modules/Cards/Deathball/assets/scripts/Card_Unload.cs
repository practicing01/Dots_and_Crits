function Module_Card_Deathball::Card_Unload(%this)
{

%this.Ass_Unload();

%this.Simset_Deathballs.deleteObjects();

%this.Simset_Deathballs.delete();

}
