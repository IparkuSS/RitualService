   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	        FuneralServices.MenWithAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$'  !Добовление венков��5	   	   $��513.185��6#   $��533.146��64   
���   � � 
ResizeMode$ NoResize=�6W    � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      � 
���   �$��0,0,0,1q�6   $	��900��6/   $	��500��6<   .+�5   
   �� $	��200��6   $��
10,55,20,0q�6    $	��Top=�64    �� Padding$ 30q�6L   $	��800��6Y    �� CornerRadius$ 20��6i   $	��345��6{   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ 	#FF38B438��6#    � Offset$ 0Q�65   � 5      $ 	#FFC72F2F��6#   $ 1Q�65   5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ Yellow��63      ShadowDepth$ 10Q�6B   ._�5      �� $��	0,0,0,-30q�6   .+�5      �� $'��!Добовление венков��6   $��30(�65   $
��bold"�6C   $��	0 0 0 20 q�6U   �� 5       -   5         ��Name$ 	classWree��5    6    �� 	MaxLength$ 40��6I   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$2 ,Введите навзвание венка��6X    %  !MaterialDesignFloatingHintTextBox#��[  6�   ��6   �� *
classWre+6�   �� 5!      -   5        $ 	typeWreaa��5!   6   $ 40��6I   $&  Введите тип венка��6X   #��[  6�   ��6   �� *
typeWrea+6�   �� 5"      -   5        $ 	skladKoll��5"   3   $ 8��6F   $* $Введите класс венка��6T   #��[  6�   ��6   �� *typeV+6�   � 5$      $��0 0 0 20q�6   $	��108��6)   .+�5&      �� -   5        $
��ОК��5&       �� 	IsDefault . $��
0,27,282,0q�6P    ! MaterialDesignFlatMidBgButton#��[ 6d   $��30��6�   $	��Top=�6�   �� 5'      $��Отмена��6    �� IsCancel . $��250,27,0,51q�6?   #��[ 6T   $
��Auto��6�   5(      5)      5*      5+      5,      