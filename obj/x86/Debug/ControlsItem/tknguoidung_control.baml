   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:UngdungHRM.ControlsUngdungHRM.Controls  5      -    'UngdungHRM.Controls.tknguoidung_control   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:UngdungHRM.Controls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffects  5   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�6.     5      $ SlideInFromRight=�6.   .��5   
   �  � RowDefinitions 5      �� 5      $��45 �6    �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  #  MaterialDesignFlatLightBgButton#��[  6   
��� � �
�������$��0 0 10 0q�5      $	��120��5      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5      .��5      �� $ 
Horizontal=�6!   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PencilPlus=�62   $��Center=�6D   �� 5      $��Thêm mới��6$   $��5 0 0 0q�64   5       5!      �� 5#      #��[  6   ���	#FFD63512
�������$��0 0 10 0q�5&      $	��120��5'      
������ $ 15��5)      .��5*      �� $ 
Horizontal=�6!   .+�5+        $ Close=�62   $��Center=�6?   �� 5,      $
��Xóa��6$   $��5 0 0 0q�6/   5-      5.      5/      �� 50      $��Bottom=�6   ���	#FF63636363   &   System.Windows.Controls.DataGrid  51      $��1��6      AutoGenerateColumns .     HeadersVisibility$	 All=�53      
������    Columns 55      4  .System.Windows.Controls.DataGridCheckBoxColumn  56       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn	   ElementStyle#	 [ 57   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle
   EditingElementStyle#
 [ 58   -      Binding 56   -   �� *
IsSelected+ �� UpdateSourceTrigger$ PropertyChanged=�,	  &System.Windows.Controls.DataGridColumn 	  Header 59      �� 5:      
������ ._�5;   "   ��  d� 	IsChecked$ FalseY�5<   %   5=       	  HeaderStyle 5?      �� 5@       �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 6$    & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 5A   $   .�5B   "   ��  �� Property � �� �� Value$ Center=�6O   5C      5E      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5G      $ Tên người dùng��5I       	  Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5J       	  
IsReadOnly .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle#
 [ 5L       5H      �� *	Numeric+ 5M      �� 5N      " 
 5O      # [ 5P      .�5Q   "   ��  � ��$ Right=�5S      �� 5T   "    � �� 5V   &   �� 5W   *   .R�5X   .   �� $
��Wrap=�5Y       �� TextAlignment$ Right=�5[      ��5Z      �� 5[      5\   +   5^   #   5_      	 5a      �� 5b      " ��5c       ) %MaterialDesignDataGridTextColumnStyle# [ 5d      .�5e   "   ��  � ��$ Right=�5g      5h      5j        5l      $ Mô tả cho việc làm��5n      $
 Auto 5o       . #
 [ 5q       5m      �� *	Numeric+ 5r      �� 5s      " 
 5t      # [ 5u      .�5v   "   ��  � ��$ Right=�5x      �� 5y   "    � �� 5{   &   �� 5|   *   .R�5}   .   �� $
��Wrap=�5~      $ Right=�5�      ��5      �� 5�      5�   +   5�   #   5�      	 5�      �� 5�      " ��5�      # [ 5�      .�5�   "   ��  � ��$ Right=�5�      5�      5�      5�      5�      5�      5�      