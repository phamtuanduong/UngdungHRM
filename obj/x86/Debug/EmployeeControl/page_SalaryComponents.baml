   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UngdungHRM.EmployeeControlUngdungHRM.EmployeeControl  5      6    0UngdungHRM.EmployeeControl.page_SalaryComponents   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:UngdungHRM.EmployeeControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$  page_SalaryComponents��5	      .��5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
dialogHost��5          DialogContent 5   
   � 5      -   5         �Name$ dialogHostControl��5      .��5   
   �� $
��Auto=�6   $��Disabled=�6:   .��5      � $��1��6   $��5q�6     � RowDefinitions 5      �� 5      $��30 �6$   �� 5      .+�5      ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6+   ���#F7F6F6$��2��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+   	   ShadowDepth$	 1Q�6:   
   	Direction$	
 270Q�6J      MaterialDesignShadow   Color# [  6Z      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   5      �� 5      ���#EFEFEF$ 	10 10 0 0��5      ._�5       �� $��Liên hệ khẩn cấp��6    ���	#B2000000$
��Bold"�5!   ;   $��10 0 0 0q�5"   $   $��Center=�5#   $   5%      � 5'      $��	15 0 15 0q�6   $��2��6*    5(      �� 5)      $��45 �6(   �� 5*      .+�5-      ��  �� Orientation$ 
Horizontal=�6!   .+�5.      �� -   5         # MaterialDesignFlatLightBgButton#��[ 5.   !   
��� � �
�������$��0 0 10 0q�51      $	��120��52      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��55      .��56      �� $ 
Horizontal=�6)   .+�57   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PencilPlus=�6:   $��Center=�6L   �� 58   "   $��Thêm mới��6,   $��5 0 0 0q�6<   59      5:      �� 5<      -   5        #��[ 5<   !   ���	#FFD63512
�������$��0 0 10 0q�5?      $	��120��5@      
������ $ 15��5C      .��5D      �� $ 
Horizontal=�6)   .+�5E   "     $ Close=�6:   $��Center=�6G   �� 5F   "   $
��Xóa��6,   $��5 0 0 0q�67   5G      5H      5I      �� 5J      $��Bottom=�6    ���	#FF6363636;   &   System.Windows.Controls.DataGrid  5K      -   5          Name$
 data��5K      $��1��6-      AutoGenerateColumns .     HeadersVisibility$	 All=�5M      
������    CanUserAddRows .  $��Stretch=�5Q      $��Stretch=�5R         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5S      $	��200��5U      ��5O      �� *
ListItem+   Columns 5V      4  .System.Windows.Controls.DataGridCheckBoxColumn  5W       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5X   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5Y   -   ,	  &System.Windows.Controls.DataGridColumn 	  Width$ 50 5Z   -      Binding 5W   5   �� *
IsSelect+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 	  Header 5[   "   �� 5\   &   
������ ._�5]   *   �� -   5         ��Name$ checkAll��5]   3    d� 	IsChecked 6F   �� *IsAllSelect+5_   '     	  HeaderStyle  5a   "   �� 5b   &   ! �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader"! 
 6,    & "MaterialDesignDataGridColumnHeader" �� BasedOn#" [ 5c   $   .�5d   *   �� # �� Property# � ��$ �� Value$$ Center=�6W   5e   '   5g      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5j      $ Thành phần lương��5l      % 	  
IsReadOnly% .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5n       5k      �� *SalaryComponent+  5o   "   �� 5p   &   "! 
 5q      #" [ 5r      .�5s   *   �� # � ��$
$ Left=�5u      �� 5v   *   # � ��$ 5x   .   �� 5y   2   .R�5z   6   �� $
��Wrap=�5{      & �� TextAlignment$
& Left=�5}      ��5|      �� 5}      5~   3   5�   +   5�   '    5�   "   �� 5�   &   "! ��5�       ) %MaterialDesignDataGridTextColumnStyle#" [ 5�      .�5�   *   �� # � ��$
$ Left=�5�      5�   '   5�        5�      $ Tần suất thanh toán��5�      % . # [ 5�       5�      �� *PayFrequency+  5�   "   �� 5�   &   "! 
 5�      #" [ 5�      .�5�   *   �� # � ��$
$ Left=�5�      �� 5�   *   # � ��$ 5�   .   �� 5�   2   .R�5�   6   �� $
��Wrap=�5�      $
& Left=�5�      ��5�      �� 5�      5�   3   5�   +   5�   '    5�   "   �� 5�   &   "! ��5�      #" [ 5�      .�5�   *   �� # � ��$
$ Left=�5�      5�   '   5�        5�      $ Tiền tệ��5�      % . # [ 5�       5�      �� *
Currency+  5�   "   �� 5�   &   "! 
 5�      #" [ 5�      .�5�   *   �� # � ��$
$ Left=�5�      �� 5�   *   # � ��$ 5�   .   �� 5�   2   .R�5�   6   �� $
��Wrap=�5�      $
& Left=�5�      ��5�      �� 5�      5�   3   5�   +   5�   '    5�   "   �� 5�   &   "! ��5�      #" [ 5�      .�5�   *   �� # � ��$
$ Left=�5�      5�   '   5�        5�      $ Số tiền��5�      % . # [ 5�       5�      �� *Amount+  5�   "   �� 5�   &   "! 
 5�      #" [ 5�      .�5�   *   �� # � ��$
$ Left=�5�      �� 5�   *   # � ��$ 5�   .   �� 5�   2   .R�5�   6   �� $
��Wrap=�5�      $
& Left=�5�      ��5�      �� 5�      5�   3   5�   +   5�   '    5�   "   �� 5�   &   "! ��5�      #" [ 5�      .�5�   *   �� # � ��$
$ Left=�5�      5�   '   5�      5�      5�      5�      5      5     5     