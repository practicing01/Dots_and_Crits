function Module_Card_Laser::create(%this)
{

exec("./assets/scripts/Card_Preload.cs");
exec("./assets/scripts/Card_Load.cs");
exec("./assets/scripts/Card_Unload.cs");

}

function Module_Card_Laser::destroy(%this)
{

%this.Card_Unload();

}
