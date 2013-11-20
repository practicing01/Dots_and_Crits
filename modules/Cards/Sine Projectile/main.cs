function Module_Card_Sine_Projectile::create(%this)
{

exec("./assets/scripts/Card_Preload.cs");
exec("./assets/scripts/Card_Load.cs");
exec("./assets/scripts/Card_Unload.cs");

}

function Module_Card_Sine_Projectile::destroy(%this)
{

%this.Card_Unload();

}
