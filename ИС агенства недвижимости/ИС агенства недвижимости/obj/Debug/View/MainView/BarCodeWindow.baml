   M S B A M L   `   `   `  ����i  eИС агенства недвижимости, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Jclr-namespace:ИС_агенства_недвижимости.View.MainView<ИС_агенства_недвижимости.View.MainView  5   	   P    JИС_агенства_недвижимости.View.MainView.BarCodeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   \localJclr-namespace:ИС_агенства_недвижимости.View.MainView     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6L     � Title$  BarCodeWindow��5   	   $	��400��6   $	��400��6,    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�6k    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   ��  �� CornerRadius$ 10��6   ��5      �� 5      .��5      �  � Color$ 	#FF5C7E95��6#    � Offset$	 0.0Q�65   � 5      $ Black��6#   $ 1Q�61   5      ._�5      �� .+�5      �� -   5         ��Name$ 	closeButt��5      
������ $��359,0,0,-10q�5      $��30��5      $��30��5      
������ $��Right=�5   O   ��5      �� 5      	 �� 
TargetType"	 ��6    .�5      �� 
 �� Property
 � �� �� Value$ Fonts/#Dosis)�6G   �� 5      
 � �� 6;   Z� �� 5      
 �@�Cursor$
 Hand��67    �� Triggers 5      P� 5   "    P� Property �@J�IsMouseOver P� Value . . �5   &   �� 
 � ��
 ���� 6C   5    #   5"      ��5$      �� 5%       �� 
TargetType" ��6*   .R�5&      �� $��30��6%   $��30��60   #��z��5'   !   ._�5(   "   �� $��Center=�63   $��Center=�6N   5)      5*      .��5,      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
�������$��20��6N   $��20��6Y   5-      �� 5.      $9��3Генерация штриш-кода услуги��6   $��24(�6?   
�������$R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6`   $��Center=�6�   $��Center=�6�   $��0,50,0,0q�6�   �� 5/      -   5         ��Name$ 
barCodeIMG��5/      $	��120��6,   $	��290��69   $��0,30,0,0q�6E   �� 50      -   5         ��Name$ 
barCodeLBL��50      $��18(�6,   $��Center=�6:   $��Center=�6U   ���	#DD000000
�������$	��290��6�   $��Center=�6�   �� 51      -   5        $ saveBarCodeBN��51      $��Сохранить��60   $��40��6D   $	��140��6P   $
��0 30q�6\   6j   53      54      56      57      