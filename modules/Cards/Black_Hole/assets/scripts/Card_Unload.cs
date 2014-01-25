function Module_Card_Black_Hole::Card_Unload(%this)
{

%this.Ass_Unload();

%this.Simset_Objects.deleteObjects();

%this.Simset_Objects.delete();

}
