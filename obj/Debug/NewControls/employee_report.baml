   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5      ,    &UngdungHRM.NewControls.employee_report   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:UngdungHRM.NewControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��450��5
      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffects  5   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�6.     5      $ SlideInFromRight=�6.   .��5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
dialogHost��5   $      DialogContent 5      � 5      -   5         �Name$ dialogHostControl��5      .��5      �  � RowDefinitions 5      �� 5      $��40 �6$   �� 5      $��* �6$   .+�5      ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6+   
�������$��2��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 5Q�6+   
   ShadowDepth$
 1Q�6:      	Direction$	 270Q�6J      MaterialDesignShadow   Color# [  6Z      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   5!      �� 5#      ���#EFEFEF$ 	10 10 0 0��5$      ._�5%      �� $��THỐNG KÊ NHÂN VIÊN��6    ���	#B2000000$
��Bold"�5&   ;   $��10 0 0 0q�5'   $   $��Center=�5(   $   5)      � 5*      $��1��6   $��10q�6$    5+      �� 5,      $��45 �6(   �� 5-      .+�50      ��  �� Orientation$ 
Horizontal=�6!   .+�51      �� -   5         # MaterialDesignFlatLightBgButton#��[ 51   !   
��� � �
�������$��0 0 10 0q�54      $	��120��55      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��58      .��59      �� $ 
Horizontal=�6)   .+�5:   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PencilPlus=�6:   $��Center=�6L   �� 5;   "   $��Thêm mới��6,   $��5 0 0 0q�6<   5<      5=      �� 5?      -   5        #��[ 5?   !   ���	#FFD63512
�������$��0 0 10 0q�5B      $	��120��5C      
������ $ 15��5F      .��5G      �� $ 
Horizontal=�6)   .+�5H   "     $ Close=�6:   $��Center=�6G   �� 5I   "   $
��Xóa��6,   $��5 0 0 0q�67   5J      5K      5L      �� 5M      $��Bottom=�6    ���	#FF6363636;   &   System.Windows.Controls.DataGrid  5N      -   5          Name$
 data��5N      $��1��6-      AutoGenerateColumns .     HeadersVisibility$	 All=�5P      
������    CanUserAddRows .  $��Stretch=�5T      $��Stretch=�5U         ColumnWidth5	  /System.Windows.Controls.DataGridLengthConverter$ *	 5V      ��5R      �� *list+   Columns 5X      4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5Y       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5Z   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5[   -   ,  &System.Windows.Controls.DataGridColumn   Width$ 50	 5\   -      Binding 5Y   5   �� *
IsSelect+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Header 5]   "   �� 5^   &   
������ ._�5_   *   �� -   5         ��Name$ checkAll��5_   3     d� 	IsChecked  6F   �� *IsAllSelect+5`   '   !   HeaderStyle! 5b   "   �� 5c   &   " �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader""  6,    & "MaterialDesignDataGridColumnHeader# �� BasedOn## [ 5d   $   .�5e   *   �� $ �� Property$ � ��% �� Value$% Center=�6W   5f   '   5h      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5j      $ Tên báo cáo��5l      &   
IsReadOnly& .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5n       5k      �� *Name+! 5o   "   �� 5p   &   ""  5q      ## [ 5r      .�5s   *   �� $ � ��$
% Left=�5u      �� 5v   *   $ � ��% 5x   .   �� 5y   2   .R�5z   6   �� $
��Wrap=�5{      ' �� TextAlignment$
' Left=�5}      $��Center=�6(   ��5|      �� 5}   (   5~   3   5�   +   5�   '    5�   "   �� 5�   &   "" ��5�       ) %MaterialDesignDataGridTextColumnStyle## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      5�   '   5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $	 Xem��5�   !   (   CellTemplate( 5�   "   �� 5�   &   .R�5�   *   �� -   5           MaterialDesignOutlinedButton#��[ 5�   1   $	��150��5�   1   $
��Left=�5�   1   
) � Tag) 5�   1   �� *ID+.��5�   .     $
 Play=�6F   5�   +   5�   '   5�      5�      5�      5�      5�      5�      5�      