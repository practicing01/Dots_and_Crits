exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Card_Initialize.cs");
exec("./Relay_Module_Function.cs");
exec("./Card_Cast.cs");
exec("./Input_Touch/Input_Touch.cs");
exec("./onAction/Actions.cs");
exec("./Class_Toggle_Projectile_Projectile/Class_Toggle_Projectile_Projectile.cs");

function Module_Card_Toggle_Projectile::Card_Load(%this)
{

%this.Ass_Load();

%this.Initialize_Variables();

%this.Card_Initialize();

}
