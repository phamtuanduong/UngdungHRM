   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:UngdungHRM.ControlsItemUngdungHRM.ControlsItem  5      +    %UngdungHRM.ControlsItem.employee_list   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:UngdungHRM.ControlsItem     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      )  #MaterialDesignThemes.Wpf.DialogHost  -   5           Name$  
dialogHost��5
          DialogContent 5   
   � 5      -   5         �Name$ dialogHostControl��5      .��5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�62     5      $ SlideInFromRight=�62   .��5      �  � RowDefinitions 5      �� 5      $��40 �6$   �� 5      $��* �6$   .+�5      ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6+   
�������$��2��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 5Q�6+   
   ShadowDepth$
 1Q�6:      	Direction$	 270Q�6J      MaterialDesignShadow   Color# [  6Z      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   5      �� 5!      ���#EFEFEF$ 	10 10 0 0��5"      ._�5#      �� $��THÔNG TIN NHÂN VIÊN��6    ���	#B2000000$
��Bold"�5$   ;   $��10 0 0 0q�5%   $   $��Center=�5&   $   5'      � 5(      $��1��6   $��10q�6$    5)      �� 5*      $��45 �6(   �� 5+      .+�5.      ��  �� Orientation$ 
Horizontal=�6!   .+�5/      �� -   5         # MaterialDesignFlatLightBgButton#��[ 5/   !   
��� � �
�������$��0 0 10 0q�52      $	��120��53      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��56      .��57      �� $ 
Horizontal=�6)   .+�58   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PencilPlus=�6:   $��Center=�6L   �� 59   "   $��Thêm mới��6,   $��5 0 0 0q�6<   5:      5;      �� 5=      -   5        #��[ 5=   !   ���	#FFD63512
�������$��0 0 10 0q�5@      $	��120��5A      
������ $ 15��5D      .��5E      �� $ 
Horizontal=�6)   .+�5F   "     $ Close=�6:   $��Center=�6G   �� 5G   "   $
��Xóa��6,   $��5 0 0 0q�67   5H      5I      5J      �� 5L      -   5        #��[ 5L      ���	#B236D612
�������$��0 0 10 0q�5O      $	��150��5P      $��Right=�5Q      
������ $ 15��5T      .��5U      �� $ 
Horizontal=�6%   .+�5V        $ 	FileChart=�66   $��Center=�6G   �� 5W      $��Xuất báo cáo��6(   $��5 0 0 0q�6<   5X      5Y      �� 5[      $��Bottom=�6    ���	#FF6363636;   &   System.Windows.Controls.DataGrid  5\      -   5          Name$
 data��5\      $��1��6-      AutoGenerateColumns .     HeadersVisibility$	 All=�5^      
������    CanUserAddRows .  $��Stretch=�5b      $��Stretch=�5c         ColumnWidth5	  /System.Windows.Controls.DataGridLengthConverter$ *	 5d      ��5`      �� *list+   Columns 5f      4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5g       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5h   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5i   -   ,  &System.Windows.Controls.DataGridColumn   Width$ 50	 5j   -      Binding 5g   5   �� *
IsSelect+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Header 5k   "   �� 5l   &   
������ ._�5m   *   �� -   5         ��Name$ checkAll��5m   3     d� 	IsChecked  6F   �� *IsAllSelect+5n   %   5o   '   !   HeaderStyle! 5q   "   �� 5r   &   " �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader""  6,    & "MaterialDesignDataGridColumnHeader# �� BasedOn## [ 5s   $   .�5t   *   �� $ �� Property$ � ��% �� Value$% Center=�6W   5u   '   5w      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5y      $ Mã NV��5{      &   
IsReadOnly& .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5}       5z      �� *
EmployeeId+! 5~   "   �� 5   &   ""  5�      ## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      �� 5�   *   $ � ��% 5�   .   �� 5�   2   .R�5�   6   �� $
��Wrap=�5�      ' �� TextAlignment$
' Left=�5�      ��5�      �� 5�      5�   3   5�   +   5�   '    5�   "   �� 5�   &   "" ��5�       ) %MaterialDesignDataGridTextColumnStyle## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      5�   '   5�        5�      $ Họ và Tên đệm��5�      & . # [ 5�       5�      �� *FMName+! 5�   "   �� 5�   &   ""  5�      ## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      �� 5�   *   $ � ��% 5�   .   �� 5�   2   .R�5�   6   �� $
��Wrap=�5�      $
' Left=�5�      ��5�      �� 5�      5�   3   5�   +   5�   '    5�   "   �� 5�   &   "" ��5�      ## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      5�   '   5�        5�      $
 Tên��5�      & . # [ 5�       5�      �� *	FirstName+! 5�   "   �� 5�   &   ""  5�      ## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      �� 5�   *   $ � ��% 5�   .   �� 5�   2   .R�5�   6   �� $
��Wrap=�5�      $
' Left=�5�      ��5�      �� 5�      5�   3   5�   +   5�   '    5�   "   �� 5�   &   "" ��5�      ## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      5�   '   5�        5�      $ Chức vụ��5�      (   MinWidth$	( 100Q�5�      & . # [ 5�       5�      �� *Chucvu+! 5�   "   �� 5�   &   ""  5�      ## [ 5�      .�5�   *   �� $ � ��$
% Left=�5�      �� 5�   *   $ � ��% 5�   .   �� 5�   2   .R�5�   6   �� $
��Wrap=�5�      $
' Left=�5�      ��5�      �� 5�      5�   3   5�   +   5�   '    5�   "   �� 5   &   "" ��5     ## [ 5     .�5  *   �� $ � ��$
% Left=�5     5  '   5       5
     $ Tình trạng việc làm��5     & . # [ 5      5     �� *Tinhtrangvl+! 5  "   �� 5  &   ""  5     ## [ 5     .�5  *   �� $ � ��$
% Left=�5     �� 5  *   $ � ��% 5  .   �� 5  2   .R�5  6   �� $
��Wrap=�5     $
' Left=�5     ��5     �� 5     5  3   5   +   5!  '    5#  "   �� 5$  &   "" ��5%     ## [ 5&     .�5'  *   �� $ � ��$
% Left=�5)     5*  '   5,       5.     $ Đơn vị phụ��50     & . # [ 52      5/     �� *dvphu+! 53  "   �� 54  &   ""  55     ## [ 56     .�57  *   �� $ � ��$
% Left=�59     �� 5:  *   $ � ��% 5<  .   �� 5=  2   .R�5>  6   �� $
��Wrap=�5?     $
' Left=�5A     ��5@     �� 5A     5B  3   5D  +   5E  '    5G  "   �� 5H  &   "" ��5I     ## [ 5J     .�5K  *   �� $ � ��$
% Left=�5M     5N  '   5P       5R     $ Người quản lí��5T     & . # [ 5V      5S     �� *	Nguoiql+! 5W  "   �� 5X  &   ""  5Y     ## [ 5Z     .�5[  *   �� $ � ��$
% Left=�5]     �� 5^  *   $ � ��% 5`  .   �� 5a  2   .R�5b  6   �� $
��Wrap=�5c     $
' Left=�5e     ��5d     �� 5e     5f  3   5h  +   5i  '    5k  "   �� 5l  &   "" ��5m     ## [ 5n     .�5o  *   �� $ � ��$
% Left=�5q     5r  '   5t     5v     5w     5x     5y     5z     5{     