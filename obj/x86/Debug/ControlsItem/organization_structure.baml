   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:UngdungHRM.ControlsItemUngdungHRM.ControlsItem  5      1clr-namespace:UngdungHRM.DataUngdungHRM.Data  5      4    .UngdungHRM.ControlsItem.organization_structure   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:UngdungHRM.ControlsItem     5      .selfclr-namespace:UngdungHRM.Data     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5      �   � RowDefinitions  5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5        $��	checkEdit��5      $y�	Collapsed=�6$   R� 5   
   -   5         R�Name$ xControl��5      ��5      �� *MovieCategories+��5      �� 5       �� DataType   UngdungHRM.Data.Structure"  6+    �� ItemsSource 6N   �� *	ListChild+.R�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5      $
��Auto �6/   �� 5      $
��Auto �6/   .+�5      �� -   5        $��	Underline{�5!   $   $��15(�5"   $    � Cursor$
 Hand��5#   $    �� TextAlignment$ Center=�5%   $   $��Center=�5&   $   ��5   $   �� *Name+
 � Tag 5    $   �� *ID+5&   $   �� 5)      -   5         &  "MaterialDesignIconForegroundButton#��[  5)   !   $��1��5*   !   
��� � �y�5+   !   �� *	IsChecked+ �� ElementName$ 	checkEdit��   BooleanToVisibilityConverter	 �� 	Converter#	 [  5.   !   �� *ID+.��5/      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$

 Plus=�66   50      �� 52      -   5        #��[  52   !   $��2��53   !   
���**��y�54   !   �� *	IsChecked+$ 	checkEdit��#	 [  57   !   �� *ID+.��58        $
 Close=�66   59      5;      5<      5>      �� 5@   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��	0 10 0 10q�5A      $��Center=�5B      .+�5C      �� -   5         ��Name$ btnSave��5C       # MaterialDesignFlatLightBgButton#��[ 6&   ���	#FF086912
�������$��0 0 10 0q�5F      $	��120��5G      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5J      .��6C   SỬA ĐỔI5L      �� 5N      -   5        #��[ 5N      ���	#FF4D4D4D
�������$��0 0 10 0q�5Q      $	��120��5R      
������ $ 15��5U      y�5S      �� *	IsChecked+$ 	checkEdit��#	 [ .��5V   .   
HỦY BỎ5X      5Y      5Z      5[      