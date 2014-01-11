function Module_Card_Vehicle_Orca::create(%this)
{

exec("./assets/scripts/Card_Preload.cs");
exec("./assets/scripts/Card_Load.cs");
exec("./assets/scripts/Card_Unload.cs");

}

function Module_Card_Vehicle_Orca::destroy(%this)
{

%this.Card_Unload();

}
