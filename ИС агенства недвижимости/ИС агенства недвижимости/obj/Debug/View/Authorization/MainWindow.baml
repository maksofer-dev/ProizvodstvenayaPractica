   M S B A M L   `   `   `  ����i  eИС агенства недвижимости, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ИС_агенства_недвижимости.ИС_агенства_недвижимости  5   	   ?    9ИС_агенства_недвижимости.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   Hlocal<clr-namespace:ИС_агенства_недвижимости  5   	   -   5          �Name$  
mainWindow��5   	    � Title$6 0ИС агентство недвижимости��5	   	   $	��570��5
   	   $	��400��5   	    � 
ResizeMode$ NoResize=�5   	    � SizeToContent$ WidthAndHeight=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ /Images/Лого.PNG��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      � .+�5   
   ��  �� CornerRadius$ 10��6   ��5      �� 5      .��5      � 	 � Color$	 	#FF5C7E95��6#   
 � Offset$	
 0.0Q�65   � 5      $	 Black��6#   $
 1Q�61   5      ._�5"      �� .+�5$      �� -   5         ��Name$ mainWIndowBorder��5$      $	��155��63   $ 10,10, 0, 0��6@   ._�5&      �� .+�5'      �� -   5         ��Name$ 	closeButt��5'   !   
������ $��359,0,0,-10q�5)      $��30��5*      $��30��5+      
������ $��Right=�5,   O   ��5-      �� 5.   "    �� 
TargetType" ��6(   .�5/   &   ��  �� Property � �� �� Value$ Fonts/#Dosis)�6O   �� 50   &    � �� 6C   Z� �� 51   &    �@�Cursor$
 Hand��6?    �� Triggers 52   &   P� 53   *    P� Property �@J�IsMouseOver P� Value . . �54   .   ��  � ��
 ���� 6K   55   +   57   #   ��59      �� 5:   "    �� 
TargetType" ��62   .R�5;   &   �� $��30��6-   $��30��68   #��z��5<   !   ._�5=   *   �� $��Center=�6;   $��Center=�6V   5>   '   5?   #   .��5A      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�66   
�������$��20��6V   $��20��6a   5B      �� 5C       �� Orientation$ 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5D      �� $	��230��6)   .+�5E   "   �� $1��+Агентство недвижимости��6,   $��36(�6J   $
��Wrap=�6X   $]��W/ИС агенства недвижимости;component/Fonts/#Champagne & Limousines)�6l    �� TextAlignment$ Center=�6�   
�������6�   �� 5F   "   $��"Высота"��6,   $��36(�6F   $ Center=�6T   $R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6k   ���	#FF73ABDC6�   5H      5I      5M      5O       � 5P      -   5          �Name$ frame��5P      $��Frame��6'   $	��415��67     � NavigationUIVisibility$ Hidden=�6D   $��Bottom=�6d   $
��20,0q�6   $	��360��6�   5T      5U      5W      5Y      