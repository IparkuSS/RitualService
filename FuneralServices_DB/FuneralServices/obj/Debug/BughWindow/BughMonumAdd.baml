   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	   "    FuneralServices.BughMonumAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$-  'Добовление памятника��5	   	   $��460.588��6&   $��533.146��67   
���   � � 
ResizeMode$ NoResize=�6Z    � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      � 
���   �$��
14,0,13,65q�6   $	��500��62   .+�5   
   �� $	��200��6   $��
10,55,20,0q�6    $	��Top=�64    �� Padding$ 30q�6L   $	��800��6Y    �� CornerRadius$ 20��6i   $	��259��6{   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ 	#FF38B438��6#    � Offset$ 0Q�65   � 5      $ 	#FFC72F2F��6#   $ 1Q�65   5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ Yellow��63      ShadowDepth$ 10Q�6B   ._�5      �� $��	0,0,0,-30q�6   .+�5      �� $#��Цена Памятников��6   $��30(�63   $
��bold"�6A   $��	0 0 0 20 q�6S   �� 5!      -   5         ��Name$ 
solidCofIn��5!   5    �� 	MaxLength$ 6��6I   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$B <Введите цену за  памятник(БелРуб)��6W    %  !MaterialDesignFloatingHintTextBox#��[  6�   ��6   �� *
solidMon+6�   � 5$      $��0 0 0 20q�6   $	��108��6)   .+�5&      �� -   5        $
��ОК��5&       �� 	IsDefault . $��
0,27,282,0q�6P    ! MaterialDesignFlatMidBgButton#��[ 6d   $��30��6�   $	��Top=�6�   �� 5'      $��Отмена��6    �� IsCancel . $��250,27,0,51q�6?   #��[ 6T   $
��Auto��6�   5(      5)      5*      5+      5,      