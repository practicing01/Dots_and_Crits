function Module_Card_Volley_Projectile::Card_Initialize(%this)
{

echo("Volley_Projectile initialized");

//The following code is not understood by me, credits to its respective authors
//code for Volley thanks to: Mario Klingemann: http://www.quasimondo.com/
//http://www.processing.org/discourse/alpha/board_Contributions_Beyond_action_display_num_1112719128.html
//code for rotating a vector around another vector thanks to:
//Richard Marks: http://ccpssolutions.com/nogdusforums/index.php?topic=666.0

%this.Vector_2D_Table=new SimSet();

%degree=0;
%pos="0 0";
%dest="0 0";

for (%x=0;%x<360;%x++)
{

%degree=%x;

%cx=%pos.X;
%cy=%pos.Y;

%c=mCos(%degree);
%s=mSin(%degree);

%dest="0 0";
%dest.X=%pos.X;
%dest.Y=%pos.Y+$Resolution.Y;

%dest.X-=%pos.X;
%dest.Y-=%pos.Y;
%xval=%dest.X*%c-%dest.Y*%s;
%yval=%dest.X*%s+%dest.Y*%c;
%dest.X=%xval+%pos.X;
%dest.Y=%yval+%pos.Y;

%wavevectors=new SimSet();

%dest=Scale_Vector_To_Camera(%dest);

%vector=new ScriptObject()
{
X=%dest.X;
Y=%dest.Y;
};
%wavevectors.add(%vector);

%this.Vector_2D_Table.add(%wavevectors);

}

}
