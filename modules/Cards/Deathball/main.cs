function Module_Card_Deathball::create(%this)
{

exec("./assets/scripts/Card_Preload.cs");
exec("./assets/scripts/Card_Load.cs");
exec("./assets/scripts/Card_Unload.cs");

}

function Module_Card_Deathball::destroy(%this)
{

%this.Card_Unload();

}
