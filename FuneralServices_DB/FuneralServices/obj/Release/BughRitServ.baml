   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  !    FuneralServices.BughRitServ   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Цены��$��654.993��$��1081.611��
������  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� $��
0,0,-8,-21q� � ColumnDefinitions �� ����  � RowDefinitions �� $	��498 �.+���  �� CornerRadius$ 10��$��
0,0,8,-127q����� .���  � Color$ 	#FF196A67�� � Offset$	 0.1Q�� $ #F6C900��$ 1Q��� $��30(�$
��bold"����#F6E68C$��Center=�$��500,0,478,455q�$	��106���� $�	 Цены���� �� $��25(�$
��bold"����#F6E68C$��Center=�$��0,0,665,455q�$	��419���� $3�- Информация о памятниках���� �� $��25(�$
��bold"����#F6E68C$��Center=�$��718,0,-54,455q�$	��420���� $/�) Информация о поминках���� �� $��25(�$
��bold"����#F6E68C$��Center=�$��370,297,294,158q�$	��420���� $1�+ Информация о катафалке���� �� $��imag/coffinBla.png��$��442,49,439,319q� J� RenderTransformOrigin$ 0.664,0.083&�&   System.Windows.Controls.DataGrid  -   	  Name$
	 Grid��
   AutoGenerateColumns
 .  $��10(�$��0,43,734,228q�$
��Bold"�   CanUserAddRows .  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FFAEBB2A��$ 0.704Q�� $ 	#FFCB8D20��$
 0.17Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn     FontSize$ 10Q�,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ организация��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ orgMon�  $ 10Q� . $! Номер телефона��$	 140  �� $ numPhon�  $ 10Q� . $ Цена��$ *  �� $ solidMon�  -   $	 GridTwo��
 .  $��10(�$��734,43,8,228q�$
��Bold"� .  ���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFAEBB2A��$ 0.704Q�� $ 	#FFCB8D20��$
 0.17Q�   $ 10Q� . $ Организация��$	 110  �� $ organiz�  $ 10Q� . $! номер телефона��$	 140  �� $ numPhon�  $ 10Q� . $ цена��$ *  �� $ 	solidFunr�  -   $	 
GridFthree��
 .  $��10(�$��420,336,420,-54q�$
��Bold"� .  ���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFAEBB2A��$ 0.704Q�� $ 	#FFCB8D20��$
 0.17Q�   $ 10Q� . $ 
Марка��$	 150  �� $ brand�  $ 10Q� . $ цена��$ *  �� $ solidHe�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AddThick=�$��856,285,0,0q�$��24��$��30���� -   $��Добавить цену�� &  "MaterialDesignToolForegroundButton#��[  $��Center=�$��117,271,819,175q�$��53��  $ AddThick=�$��117,285,0,0q�$��24���� -   $��Добавить цену��#��[  $��Center=�$��856,271,59,175q�$��53��$ 0.211,0.472&�  $ AddThick=�$��459,568,0,-93q�$��24��$ 2.229,0.472&�$��41���� -   $��Добавить цену��#��[  $��Center=�$��500,553,467,-107q�$��53��$ 0.211,0.472&�  $ 	ArrowBack=�$��973,553,0,-78q�$��24��$ 2.229,0.472&�$��25���� -   $��
Назад��#��[  $��Center=�$��942,548,-29,-78q�$��29��$ 0.211,0.472&�