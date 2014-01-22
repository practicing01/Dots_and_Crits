function Module_Card_Ball::create(%this)
{

exec("./assets/scripts/Card_Preload.cs");
exec("./assets/scripts/Card_Load.cs");
exec("./assets/scripts/Card_Unload.cs");

}

function Module_Card_Ball::destroy(%this)
{

%this.Card_Unload();

}
