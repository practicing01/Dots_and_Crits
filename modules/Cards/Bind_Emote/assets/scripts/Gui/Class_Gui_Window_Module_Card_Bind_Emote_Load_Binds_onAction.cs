function Class_Gui_Window_Module_Card_Bind_Emote_Load_Binds::onAction(%this)
{

%this.Module_ID_Parent.Gui_List_Binds.onDoubleClick();

}

function Class_Gui_Window_Module_Card_Bind_Emote_List_Binds::onDoubleClick(%this)
{

if (%this.getSelectedItem()!=-1)
{

exec
("./../../../../../Binds/" @
%this.getItemText
(
%this.getSelectedItem()
)
);

%this.Module_ID_Parent.Action_Map_Keys=Module_Card_Bind_Emote_Action_Map;

%this.Module_ID_Parent.Action_Map_Keys.Push();

}

}
