function Gui_Chat_Box::Send_Text(%this)
{

if ($GameConnection_Serverside_Connection!=0)
{

%Text=Gui_MLTextEdit_Chat_Box.getText();

commandToServer('Send_Text',%Text);

Gui_MLTextEdit_Chat_Box.setText("");

Gui_MLTextEdit_Chat_Box.setActive(false);

Gui_MLTextEdit_Chat_Box.setActive(true);

}

}
