function Module_Card_Speedboof::create(%this)
{

exec("./assets/scripts/Card_Load.cs");
exec("./assets/scripts/Card_Unload.cs");

}

function Module_Card_Speedboof::destroy(%this)
{

%this.Card_Unload();

}
