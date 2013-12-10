function clientCmdQuery_Response(%Done,%Connector_Name,%IP_Address)
{

if (!%Done)
{

%Server=new ScriptObject()
{
Connector_Name=%Connector_Name;
IP_Address=%IP_Address;
};

if (!isObject($Simset_Server_List))
{

$Simset_Server_List=new SimSet();

}

$Simset_Server_List.add(%Server);

Gui_List_Servers.addItem(%Connector_Name);

}
else
{

schedule(0,0,"Dots_and_Crits::Game_Connection_Delete",Dots_and_Crits,$GameConnection_Master_Server_Query);

}


}
