   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices       FuneralServices.MenegOrder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Заказы��$��614.333��$
��1305��
������  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� $��0,0,-102,-21q� � ColumnDefinitions �� ����  � RowDefinitions �� $	��498 �.+���  �� CornerRadius$ 10��$��0,0,102,-86q����� .���  � Color$ 	#FF8B117A�� � Offset$	 0.1Q�� $ 	#FF394F9B��$ 1Q��� $��30(�$
��bold"����#F6E68C$��Center=�$��504,10,337,445q�$	��560���� $� ���� $*�$Информация о заказе���� �� $��imag/coffinBla.png��$��1069,10,-11,378q� J� RenderTransformOrigin$ 0.664,0.083&�&   System.Windows.Controls.DataGrid  -   	  Name$
	 Grid��
   AutoGenerateColumns
 .  $��10(�$��0,60,295,-79q�$
��Bold"�   CanUserAddRows .  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FF4F2895��$ 0.704Q�� $ 	#FFA92DC5��$
 0.17Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn     FontSize$ 10Q�,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Пол��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$	 flo�  $ 10Q� . $ Вид похорон��$	 120  �� $ viewFunr�  $ 10Q� . $ 
адрес��$ 80  �� $ adress�4  .System.Windows.Controls.DataGridTemplateColumn  $ Дата��-   TwoDatColumnDat�� .    CellTemplate �� .R�(  "System.Windows.Controls.DatePicker  -    � Language$ ru-ru�   SelectedDate �� *	funDate+  $ Заказчик��-   Comb�� �� .R���  ��Name$ myCmb��-   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$) #Выберите Заказчика�� J� Opacity$ 1Q� �� SelectedValuePath$	 flo�� �� SelectedItem �� *customerSurName+  $ Гроб��-   TwoDatColumn�� �� .R��� $ myCmbForCof��-   $ Выберите гроб��$ 1Q� �� *customerClassCof+ �� Mode$ TwoWay=�  $ 
Крест��-   TwoDatColumncros�� �� .R��� $ myCmbForCros��-	   $! Выберите крест��$ 1Q� �� *customerClassCros+$ TwoWay=� � ToolTip �� *IsMarriedTooltip+  $ памятники��-
   TwoDatColumnmon�� �� .R��� $ myCmbForCros��-   $B <Выберите организацию памятников��$ 1Q� �� *customerOrgMon+$ TwoWay=� �� *IsMarriedTooltip+  $ 10Q� . $ 
Венок��$	 120  �� $ customerClassWre�  $ Катафалк��-   TwoDatColumnwrhe��$	 100  �� .R��� $ 
myCmbForhe��-   $' !Выберите катафалк��$ 1Q� �� *customerBrand+$ TwoWay=� �� IsAsync .   $ Поминки��-   TwoDatColumnwrheD�� �� .R��� $ myCmbForheV��-   $< 6Выберите оргнаизацию поминок��$ 1Q� �� *customerOrganiz+$ TwoWay=�  $ 10Q� . $ цена за копку��$	 120  �� $ SolidKop�  $ цена��-   TwoDatcColumnmon�� �� .R���   ��Name$  	myCmbFors������ *customerSolidGen+$ TwoWay=� �� *IsMarriedTooltip+�� $��15(�$��1111,144,10,-58q�.@��� $��1q�.���� ! �� Orientation$! 
Horizontal=�.+�'	  !MaterialDesignThemes.Wpf.PackIcon	  " 	  Kind$
" Text=�$��15q��� -   # ��Name$# Search��$��Center=�$	��120��$��34���� $��1q�.���� $! 
Horizontal=�.+�	  $" 	SearchAdd=�$��15q��� -   $��
Поиск�� &  "MaterialDesignToolForegroundButton#��[  $��Center=��� $��1q�.���� $! 
Horizontal=�.+�	  $	" Add=�$��15q��� -   $��Добавление��#��[  $��Center=��� $��1q�.���� $! 
Horizontal=�.+�	  $
" Edit=�$��15q��� -   $"��Редактирование��#��[  $��Center=��� $��1q�.���� $! 
Horizontal=�.+�	  $" Delete=�$��15q��� -   $��Удаление��#��[  $��Center=��� $��1q�.���� $! 
Horizontal=�.+�	  $" Flower=�$��15q��� -   $��
Венки��#��[  $��Center=��� $��1q�.���� $! 
Horizontal=�.+�	  $" Money=�$��15q��� -   $��Цена��#��[  $��Center=��� $��1q�.���� $! 
Horizontal=�.+�	  $" 	ArrowBack=�$��15q��� -   $��
Назад��#��[  $��Center=�