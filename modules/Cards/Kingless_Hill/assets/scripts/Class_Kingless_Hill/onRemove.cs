function Class_Kingless_Hill::onRemove(%this)
{

if (!isObject(%this.Simset_Player_Scores)){return;}

%this.Simset_Player_Scores.deleteObjects();

%this.Simset_Player_Scores.delete();

}
