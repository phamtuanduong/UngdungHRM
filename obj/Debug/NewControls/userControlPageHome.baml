   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UngdungHRM.NewControlsUngdungHRM.NewControls  5      0    *UngdungHRM.NewControls.userControlPageHome   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:UngdungHRM.NewControls     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��10q�5
      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffects  5   
   ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5         Kind$ FadeIn=�6.     5      $ SlideInFromRight=�6.   .��5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   
�������$��2��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R   	   Opacity$		 .42Q�6�   
   RenderingBias$
 Performance=�6�   ._�5      � .+�5      �� $)��#/UngdungHRM;component/icon/back.jpg��6   $	��Top=�5      $��0 20 0 0q�5      � 5      $��0 0 0 20q�6   $��Bottom=�6.   $��Center=�6I   $	��465��6f   .+�5      ��  # MaterialDesignFlatLightBgButton#��[ 6   
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      ���	#FF009CA9$	��220��5!      $��80��6!   $��0q�6-   .��5"      � $��48��6   $	��168��6+    � ColumnDefinitions 5#      �� 5$   "   $
��Auto �63   �� 5%   "    � RowDefinitions 5'      �� 5(   "   $��* �60   �� 5)   "   $
��Auto �60   .+�5,      �� $ 10��6%   $��45��67   $��50��6C   ���	#B2FFCFF0$��2��5-   4   ._�5.   "   �� $��35��6(   $/��)/UngdungHRM;component/icon/ApplyLeave.png��64   5/      �� 51      $��Xin nghỉ phép��6(   $��1��52       
�������$��5 0 0 0q�54       $��Center=�55   $   $��Normal"�6?   $��
Leelawadee)�6S   �� 56      $��Assign Leave��6(   $��1��57       $��1��58   $   
�������$��5 0 0 0q�5:       $��Center=�5;   $   $��Segoe UI Light)�6?   $��Normal"�6[   5<      5=      �� 5?      #��[ 6   
������ $ 10��5A      ���	#FF3A8BCC$��10 0 0 0q�5C      $	��220��5D      $��80��6!   $��0q�6-   .��5E      � $��48��6   $	��168��6+    5F      �� 5G   "   $
��Auto �63   �� 5H   "    5J      �� 5K   "   $��* �60   �� 5L   "   $
��Auto �60   .+�5O      �� $ 10��6%   $��45��67   $��50��6C   ���	#B2FFCFF0$��2��5P   4   ._�5Q   "   �� $��35��6(   $,��&/UngdungHRM;component/icon/MyLeave.png��64   5R      �� 5T      $��Danh sách nghỉ phép��6(   $��1��5U       
�������$��5 0 0 0q�5W       $��Center=�5X   $   $��Normal"�6?   $��
Leelawadee)�6S   �� 5Y      $��
Leave List��6(   $��1��5Z       $��1��5[   $   
�������$��5 0 0 0q�5]       $��Center=�5^   $   $��Segoe UI Light)�6?   $��Normal"�6[   5_      5`      �� 5a      #��[ 6   
������ $ 10��5c      ���	#FF599ACE$��0 10 0 0q�5e      $	��220��5f      $��80��6!   $��0q�6-   .��5g      � $��48��6   $	��168��6+    5h      �� 5i   "   $
��Auto �63   �� 5j   "    5l      �� 5m   "   $��* �60   �� 5n   "   $
��Auto �60   .+�5q      �� $ 10��6%   $��45��67   $��50��6C   ���	#B2FFCFF0$��2��5r   4   ._�5s   "   �� $��35��6(   $0��*/UngdungHRM;component/icon/MyTimesheet.png��64   5t      �� 5v      $��Bảng chấm công��6(   $��1��5w       
�������$��5 0 0 0q�5y       $��Center=�5z   $   $��Normal"�6?   $��
Leelawadee)�6S   �� 5{      $��
Timesheets��6(   $��1��5|       $��1��5}   $   
�������$��5 0 0 0q�5       $��Center=�5�   $   $��Segoe UI Light)�6?   $��Normal"�6[   5�      5�      �� 5�      #��[ 6   
������ $ 10��5�      ���	#FF008778$��	10 10 0 0q�5�      $	��220��5�      $��80��6!   $��0q�6-   .��5�      � $��48��6   $	��168��6+    5�      �� 5�   "   $
��Auto �63   �� 5�   "    5�      �� 5�   "   $��* �60   �� 5�   "   $
��Auto �60   .+�5�      �� $ 10��6%   $��45��67   $��50��6C   ���	#B2FFCFF0$��2��5�   4   ._�5�   "   �� $��35��6(   $3��-/UngdungHRM;component/icon/ApplyLeave (1).png��64   5�      �� 5�      $��Duyệt nghỉ phép��6(   $��1��5�       
�������$��5 0 0 0q�5�       $��Center=�5�   $   $��Normal"�6?   $��
Leelawadee)�6S   �� 5�      $��Apply Leave��6(   $��1��5�       $��1��5�   $   
�������$��5 0 0 0q�5�       $��Center=�5�   $   $��Segoe UI Light)�6?   $��Normal"�6[   5�      5�      5�      �� 5�      -   5          MaterialDesignIconButton#��[ 5�      $
��Left=�5�      $	��Top=�60   .��5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6.   5�      5�      5�      5�      5�      