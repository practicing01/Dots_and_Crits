function Dots_and_Crits::Game_Connection_Delete(%this,%Game_Connection)
{

if (isObject(%Game_Connection))
{

%Game_Connection.delete();

}

}
