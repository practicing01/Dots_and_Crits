function GameConnection::onConnect(%this,%arg0,%arg1,%arg2,%arg3,%arg4,%arg5,%arg6,
%arg7,%arg8,%arg9,%arg10,%arg11,%arg12,%arg13,%arg14,%arg15)//Master Server/Server callback
{

echo("Game onConnected. info:" SPC %this);

echo(%arg0 SPC %arg1 SPC %arg2 SPC %arg3 SPC %arg4 SPC %arg5 SPC
%arg6 SPC %arg7 SPC %arg8 SPC %arg9 SPC %arg10 SPC %arg11 SPC
%arg12 SPC %arg13 SPC %arg14 SPC %arg15);

%this.IP_Address=%this.getAddress();
%this.Connector_Name=%arg0;
%this.Connector_Type=%arg1;//"Client" or "Server"

if (%this.Connector_Type$="Client")
{

%this.String_Player_Sprite_Description=%arg2;
%this.Is_Playing=false;

}

if (!$Bool_Is_Master_Server)
{
echo("ClientGroup.getCount():" SPC ClientGroup.getCount());//banana
for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

if (%Object.Connector_Type$="Client")
{
echo("Server relaying player info:" SPC %Object SPC %Object.Connector_Name SPC %Object.String_Player_Sprite_Description);//banana
if (%Object!=%this)
{

commandToClient(%Object,'Register_Player_Information',false,%this,%this.Connector_Name,%this.String_Player_Sprite_Description);
echo("sent old client" SPC %Object SPC "the new client" SPC %this);//banana

commandToClient(%this,'Register_Player_Information',false,%Object,%Object.Connector_Name,%Object.String_Player_Sprite_Description);
echo("sent the new client" SPC %this SPC "the old client" SPC %Object);//banana
}
else
{

commandToClient(%this,'Register_Player_Information',true,%Object,%Object.Connector_Name,%Object.String_Player_Sprite_Description);
echo("sent the new client" SPC %this SPC "the old client" SPC %Object);//banana
}

}

}

}

}
