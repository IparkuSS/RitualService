   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	   D @FluentWPF, Version=0.8.0.6, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5	   	   $    FuneralServices.ManegerRitGods   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  5	   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5      )  #SourceChord.FluentWPF.AcrylicWindow    Enabled  . 
������  � AllowsTransparency .  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   $	��251��6.   $	��303��6;   .��5      � $
��Left=�6   $	��323��6&    � ColumnDefinitions 5   
   �� 5      $	��323 �6   �� 5      $��0* �6   .+�5   
   � *  $SourceChord.FluentWPF.PointerTracker   Enabled . ���	#01FFFFFF.+�5      ��  �� CornerRadius$ 10��6   ��5      �� 5      .��5      �  � Color$ #F6770E��6'   	 � Offset$		 0.0Q�67   � 5      $ #951466��6'   $	 1Q�67   5      5      �� 5      $��	0,0,-10,0q�6   .+�5      �� 
 �� Orientation$
 
Horizontal=�6   .+�5       �� -   5        
���   ���5    D   Z� ��6Z   Z� .��5!      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   5"      �� 5#      $��
Назад��6    $��12(�6-   $��10q�6;   $��Center=�6G   5$      �� 5%      $'��!Ритуальные услуги��6   $��15q�65   $��DemiBold"�6A   �� 5&      $��15(�6   .@�5'      �� $��1q�6#   .��5(      �� $
 
Horizontal=�6%   .+�5)        $ Coffin=�66   $��15q�6D   �� 5*      -   5        $��
Гробы��5*   %    &  "MaterialDesignToolForegroundButton#��[  6E   $��Center=�6�   5+      5,      �� 5.      $��1q�6#   .��5/      �� $
 
Horizontal=�6%   .+�50        $ Flower=�66   $��15q�6D   �� 51      -   5        $��
Венки��51   %   #��[  6D   $��Center=�6�   52      53      �� 54      $��1q�6#   .��55      �� $
 
Horizontal=�6%   .+�56        $ Cross=�66   $��15q�6C   �� 57      -   5        $��Кресты��57   %   #��[  6F   $��Center=�6�   58      59      5:      5<      5>      5@      5A      