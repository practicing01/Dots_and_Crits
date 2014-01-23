function clientCmdRegister_AI_Token(%Game_Connection_Handle)
{

if (%Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

$Bool_A_I_Token_Bearer=true;

}
else
{

$Bool_A_I_Token_Bearer=false;

}

}
