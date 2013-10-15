exec("./Load_Map.cs");
exec("./Load_Player_Data.cs");
exec("./Load_Cards.cs");

function Dots_and_Crits::Load_Play(%this)
{

%this.Load_Map();

%this.Load_Player_Data();

%this.Load_Cards();

}
