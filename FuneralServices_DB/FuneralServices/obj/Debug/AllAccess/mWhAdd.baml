   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	       FuneralServices.mWhAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
Венки��5
   	   $	��525��6   $��643.5��6$   
������ .��5      � $��
0,0,-92,-1q�6    � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��0,0,91,0q�6#   ��5      �� 5      .��5      �  � Color$ #0B270B��6#    � Offset$	 0.1Q�63   � 5      $ #F6C900��6#   $ 1Q�63   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��154,0,104,455q�6g   $	��436��6~   �� 6�   $'�!Добавление венков��6�   �� 6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ GridTwo��5   /      AutoGenerateColumns .  $��10(�6@   $��
0,48,91,65q�6N   $
��Bold"�6c      CanUserAddRows .  ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � $ 	#FF767C00��6#   $ 0.704Q�65   � 5      $ 	#FFBBCB20��6#   $
 0.17Q�65   � 5      $ 	#FFB6C81E��6#   $ 0.396Q�65   5      
   Columns
 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -   5        wrr��   FontSize$ 10Q�5"   V   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$! Название венка��6v      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ classWre�6�     5#      $ 10Q�6I    . $ Тип венка��6i   $	 120 6|    6%   �� $ typeWrea�6|     5$      $ 10Q�6F    . $ класс венка��6f   $	 120 6{    6%   �� $ typeV�6{     5%      $ 10Q�6F    . $ Цена за штуку��6f   $	 120 6}    6%   �� $ solid�6}   4  .System.Windows.Controls.DataGridTemplateColumn  5&      $ 
Венки��6)   $ * 68   -   5        IMM��   CellTemplate 5'      �� 5(      .R�5)      ��  ��Name$ IВMM��6%   $	��100��6W   ��64   �� $ imageCh�6W   5*      5,      5.      �� 50   
   -   5        $��Добавить��50       �� 	IsDefault . $��424,433,121,3q�6J    &  "MaterialDesignToolForegroundButton#��[  6a   $
��Auto��6�   �� 51   
   $��Отмена��6    �� IsCancel . $��30,433,508,3q�63   #��[  6I   $
��Auto��6�    J� RenderTransformOrigin$ 0.524,8.481&�6�   53      54      