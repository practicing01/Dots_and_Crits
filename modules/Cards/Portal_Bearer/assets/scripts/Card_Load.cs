exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Card_Initialize.cs");
exec("./Relay_Module_Function.cs");
exec("./Card_Cast.cs");
exec("./Input_Touch/Input_Touch.cs");
exec("./onAction/Actions.cs");
exec("./Class_Portal_Bearer_Projectile/Class_Portal_Bearer_Projectile.cs");
exec("./Class_Portal_Bearer_Portal/Class_Portal_Bearer_Portal.cs");

function Module_Card_Portal_Bearer::Card_Load(%this)
{

%this.Ass_Load();

%this.Initialize_Variables();

%this.Card_Initialize();

}
