   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UngdungHRM.EmployeeControlUngdungHRM.EmployeeControl  5      7    1UngdungHRM.EmployeeControl.page_EmergencyContacts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:UngdungHRM.EmployeeControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$  page_EmergencyContacts��5	      .��5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
dialogHost��5          DialogContent 5   
   � 5      -   5         �Name$ dialogHostControl��5      
������ 6.   .��5   
   �� $
��Auto=�6   $��Disabled=�6:   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   .+�5      � $��1��6   $��5q�6$    5      �� 5      $��30 �6(   �� 5      .+�5       ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6/   ���#F7F6F6$��2��5!       J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#         
BlurRadius$ 5Q�6/   	   ShadowDepth$	 1Q�6>   
   	Direction$	
 270Q�6N      MaterialDesignShadow   Color# [  6^      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   5%      �� 5'      ���#EFEFEF$ 	10 10 0 0��5(      ._�5)      �� $��Liên hệ khẩn cấp��6$   ���	#B2000000$
��Bold"�5*   ;   $��10 0 0 0q�5+   $   $��Center=�5,   $   5.      � 50      $��	15 0 15 0q�6   $��2��6.    51      �� 52      $��45 �6,   �� 53      .+�56      ��  �� Orientation$ 
Horizontal=�6%   .+�57      �� -   5         # MaterialDesignFlatLightBgButton#��[ 57   %   
��� � �
�������$��0 0 10 0q�5:      $	��120��5;      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5>      .��5?   "   �� $ 
Horizontal=�6-   .+�5@   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PencilPlus=�6>   $��Center=�6P   �� 5A   &   $��Thêm mới��60   $��5 0 0 0q�6@   5B   #   5C      �� 5E      -   5        #��[ 5E   %   ���	#FFD63512
�������$��0 0 10 0q�5H      $	��120��5I      
������ $ 15��5L      .��5M   "   �� $ 
Horizontal=�6-   .+�5N   &     $ Close=�6>   $��Center=�6K   �� 5O   &   $
��Xóa��60   $��5 0 0 0q�6;   5P   #   5Q      5R      �� 5S      $��Bottom=�6$   ���	#FF6363636?   &   System.Windows.Controls.DataGrid  5T      -   5          Name$
 data��5T   #   $��1��61      AutoGenerateColumns .     HeadersVisibility$	 All=�5V      
������    CanUserAddRows .  $��Stretch=�5Z      $��Stretch=�5[         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5\      $	��200��5^      ��5X      �� *
ListItem+   Columns 5_      4  .System.Windows.Controls.DataGridCheckBoxColumn  5`   "    - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5a   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5b   -   ,	  &System.Windows.Controls.DataGridColumn 	  Width$ 50 5c   -      Binding 5`   9   �� *
IsSelect+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 	  Header 5d   &   �� 5e   *   
������ ._�5f   .   �� -   5         ��Name$ checkAll��5f   7    d� 	IsChecked 6J   �� *IsAllSelect+5h   +     	  HeaderStyle  5j   &   �� 5k   *   ! �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader"! 
 60    & "MaterialDesignDataGridColumnHeader" �� BasedOn#" [ 5l   $   .�5m   .   �� # �� Property# � ��$ �� Value$$ Center=�6[   5n   +   5p   #   1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5s   "   $
 Tên��5u      % 	  
IsReadOnly% .  5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5w       5t      �� *Name+  5x   &   �� 5y   *   "! 
 5z      #" [ 5{      .�5|   .   �� # � ��$
$ Left=�5~      �� 5   .   # � ��$ 5�   2   �� 5�   6   .R�5�   :   �� $
��Wrap=�5�      & �� TextAlignment$
& Left=�5�      ��5�      �� 5�      5�   7   5�   /   5�   +    5�   &   �� 5�   *   "! ��5�       ) %MaterialDesignDataGridTextColumnStyle#" [ 5�      .�5�   .   �� # � ��$
$ Left=�5�      5�   +   5�   #     5�   "   $ Mối quan hệ��5�      % . # [ 5�       5�      �� *Relationship+  5�   &   �� 5�   *   "! 
 5�      #" [ 5�      .�5�   .   �� # � ��$
$ Left=�5�      �� 5�   .   # � ��$ 5�   2   �� 5�   6   .R�5�   :   �� $
��Wrap=�5�      $
& Left=�5�      ��5�      �� 5�      5�   7   5�   /   5�   +    5�   &   �� 5�   *   "! ��5�      #" [ 5�      .�5�   .   �� # � ��$
$ Left=�5�      5�   +   5�   #     5�   "   $  Điện thoại gia đình��5�      % . # [ 5�       5�      �� *HomeTelephone+  5�   &   �� 5�   *   "! 
 5�      #" [ 5�      .�5�   .   �� # � ��$
$ Left=�5�      �� 5�   .   # � ��$ 5�   2   �� 5�   6   .R�5�   :   �� $
��Wrap=�5�      $
& Left=�5�      ��5�      �� 5�      5�   7   5�   /   5�   +    5�   &   �� 5�   *   "! ��5�      #" [ 5�      .�5�   .   �� # � ��$
$ Left=�5�      5�   +   5�   #     5�   "   $ 
Di động��5�      % . # [ 5�       5�      �� *Mobile+  5�   &   �� 5�   *   "! 
 5�      #" [ 5�      .�5�   .   �� # � ��$
$ Left=�5�      �� 5�   .   # � ��$ 5�   2   �� 5�   6   .R�5�   :   �� $
��Wrap=�5�      $
& Left=�5�      ��5�      �� 5�      5�   7   5�   /   5�   +    5�   &   �� 5�   *   "! ��5�      #" [ 5�      .�5�   .   �� # � ��$
$ Left=�5�      5�   +   5  #     5  "   $ Điện thoại cơ quan��5     % . # [ 5      5     �� *WorkTelephone+  5  &   �� 5	  *   "! 
 5
     #" [ 5     .�5  .   �� # � ��$
$ Left=�5     �� 5  .   # � ��$ 5  2   �� 5  6   .R�5  :   �� $
��Wrap=�5     $
& Left=�5     ��5     �� 5     5  7   5  /   5  +    5  &   �� 5  *   "! ��5     #" [ 5     .�5   .   �� # � ��$
$ Left=�5"     5#  +   5%  #   5'     5(     5,     5-     5.     5/     50     