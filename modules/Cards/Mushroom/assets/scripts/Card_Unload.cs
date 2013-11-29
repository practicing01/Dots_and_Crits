function Module_Card_Mushroom::Card_Unload(%this)
{

%this.Ass_Unload();

%this.Simset_Objects.deleteObjects();

%this.Simset_Objects.delete();

}
