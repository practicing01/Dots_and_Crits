function Module_Card_Bind_Emote::create(%this)
{

exec("./assets/scripts/Card_Preload.cs");
exec("./assets/scripts/Card_Load.cs");
exec("./assets/scripts/Card_Unload.cs");

}

function Module_Card_Bind_Emote::destroy(%this)
{

%this.Card_Unload();

}
