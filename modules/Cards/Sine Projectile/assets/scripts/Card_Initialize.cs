function Module_Card_Sine_Projectile::Card_Initialize(%this)
{

echo("Sine_Projectile initialized");

//The following code is not understood by me, credits to its respective authors
//code for sine thanks to: Mario Klingemann: http://www.quasimondo.com/
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

%freq=8*((800/$Resolution.Y)*20);
%amp=30;
%phase=0;

///////////////////////////////
%dx=%dest.X-%cx;
%dy=%dest.Y-%cy;
%l=mSqrt(%dx*%dx+%dy*%dy);

%nx=%amp*%dy/%l;
%ny=%amp*-%dx/%l;

%tstep=1.0/(%l/35);//dividing by a lower number makes smoother sinoids, higher faster

for (%t=0;%t<=1.0;%t+=%tstep)
{
%a=mSin(%phase+(2*$Pie)*%t*%freq);
%xval=%cx+%t*%dx+%nx*%a;
%yval=%cy+%t*%dy+%ny*%a;
%tmpvec="0 0";%tmpvec.X=%xval;%tmpvec.Y=%yval;
%tmpvec=Scale_Vector_To_Camera(%tmpvec);
%vector=new ScriptObject()
{
X=%tmpvec.X;
Y=%tmpvec.Y;
};
%wavevectors.add(%vector);
}

%this.Vector_2D_Table.add(%wavevectors);

}

}
