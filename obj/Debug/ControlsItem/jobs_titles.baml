   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5      (    "UngdungHRM.NewControls.jobs_titles   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:UngdungHRM.NewControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffects  5   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�6.     5      $ SlideInFromRight=�6.   .��5   
   �  � RowDefinitions 5      �� 5      $��45 �6    �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         #  MaterialDesignFlatLightBgButton#��[  5      
��� � �
�������$��0 0 10 0q�5      $	��120��5      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5      .��5       �� $ 
Horizontal=�6!   .+�5!      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PencilPlus=�62   $��Center=�6D   �� 5"      $��Thêm mới��6$   $��5 0 0 0q�64   5#      5$      �� 5&      -   5        #��[  5&      ���	#FFD63512
�������$��0 0 10 0q�5)      $	��120��5*      
������ $ 15��5-      .��5.      �� $ 
Horizontal=�6!   .+�5/        $ Close=�62   $��Center=�6?   �� 50      $
��Xóa��6$   $��5 0 0 0q�6/   51      52      53      �� 54      $��Bottom=�6   ���	#FF63636363   &   System.Windows.Controls.DataGrid  55      -   5          Name$
 data��55      $��1��6%      AutoGenerateColumns .     HeadersVisibility$	 All=�57      
������ 	   CanUserAddRows	 .  $��Stretch=�5;      $��Stretch=�5<      
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 5=      ��59      �� *list+   Columns 5?      4  .System.Windows.Controls.DataGridCheckBoxColumn  5@       - )MaterialDesignDataGridCheckBoxColumnStyle1	  +System.Windows.Controls.DataGridBoundColumn 	  ElementStyle# [ 5A   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle 	  EditingElementStyle# [ 5B   -   ,
  &System.Windows.Controls.DataGridColumn 
  Width$ 50 5C   -    	  Binding 5@   -   �� *
IsSelect+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 
  Header 5D      �� 5E      
������ ._�5F   "   �� -   5         ��Name$ checkAll��5F   +    d� 	IsChecked 6>   �� *IsAllSelect+5G   %   5H       
  HeaderStyle 5J      �� 5K       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$    & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 5L   $   .�5M   "   ��  �� Property � �� �� Value$ Center=�6O   5N      5P      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5R      $  Tên vị trí việc làm��5T       
  
IsReadOnly .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5V       5S      �� *Name+ 5W      �� 5X      "  5Y      # [ 5Z      .�5[   "   ��  � ��$
 Left=�5]      �� 5^   "    � �� 5`   &   �� 5a   *   .R�5b   .   �� $
��Wrap=�5c       �� TextAlignment$
 Left=�5e      ��5d      �� 5e      5f   +   5h   #   5i       5k      �� 5l      " ��5m       ) %MaterialDesignDataGridTextColumnStyle# [ 5n      .�5o   "   ��  � ��$
 Left=�5q      5r      5t        5v      $ Mô tả cho việc làm��5x       . # [ 5z       5w      �� *Description+ 5{      �� 5|      "  5}      # [ 5~      .�5   "   ��  � ��$
 Left=�5�      �� 5�   "    � �� 5�   &   �� 5�   *   .R�5�   .   �� $
��Wrap=�5�      $
 Left=�5�      ��5�      �� 5�      5�   +   5�   #   5�       5�      �� 5�      " ��5�      # [ 5�      .�5�   "   ��  � ��$
 Left=�5�      5�      5�      5�      5�      5�      5�      