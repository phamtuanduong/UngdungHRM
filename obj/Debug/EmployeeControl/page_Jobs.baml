   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UngdungHRM.EmployeeControlUngdungHRM.EmployeeControl  5      =#clr-namespace:UngdungHRM.ConvertersUngdungHRM.Converters  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      *    $UngdungHRM.EmployeeControl.page_Jobs   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:UngdungHRM.EmployeeControl     5      7convert#clr-namespace:UngdungHRM.Converters     5      6sys&clr-namespace:System;assembly=mscorlib     5	      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$  	page_Jobs��5       � 	Resources 5      -   'UngdungHRM.Converters.InvertedBoolToVis   InvertedBoolToVis/   )UngdungHRM.Converters.FormatTextConverter  FormatTextConverter  	stringTer��%m   &	        &	      &	 &       5   
   6$     5   
   6&   ��5   
   Kết thúc vào:��67   5      .��5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
dialogHost��5          DialogContent 5   
   � 5      -   5         �Name$ dialogHostControl��5      .��5   
   �  � RowDefinitions 5      �� 5      $��30 �6    �� 5      .+�5      �� -   5         ��Name$ 	checkEdit��5      �� 5"       �� CornerRadius$ 10��6    �� Padding$ 10q�6'   ���#F7F6F6$��2��5#      	 J� Effect	 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%      
   
BlurRadius$
 5Q�6'      ShadowDepth$ 1Q�66      	Direction$	 270Q�6F     MaterialDesignShadow   Color# [ 6V      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   5'      �� 5)      ���#EFEFEF$ 	10 10 0 0��5*      ._�5+      �� -   5         ��Name$ txtNameControl��5+      $��Thông tin cá nhân��64   ���	#B2000000$
��Bold"�5,   ;   $��10 0 0 0q�5-   $   $��Center=�5.   $   $��Yu Gothic Light)�6?   $��16(�6\   5/      � 51      $��	15 0 15 0q�6   $��2��6&    54      �� 55      $��* �6$   �� 56      $
��Auto �6$   .+�59      �� $��Disabled=�6   ��.   for_scrollviewer#��[ 5;      $��Visible=�5<      .��5=      �  5>      �� 5?      �� 5@      �� 5A      �� 5B      �� 5C      �� 5D       � ColumnDefinitions 5G      �� 5H      $
��Auto �6/   �� 5I      �� 5J      �� 5K      .+�5M      �� $��Chức vụ��6$   $��0��5N      $��Center=�5O      $��0 5 0 0q�5P      $��14(�5R      �� 5S      $��Đặc tả công việc��6$   $��1��6<   $��0 15 0 0q�5T      $��Center=�5U      $��14(�5V      �� 5X      $��Tình trạng việc làm��6$   $��2��6?   $��0 15 0 0q�5Y      $��Center=�5Z      $��14(�5[      �� 5]      $��Ngành nghề��6$   $��3��66   $��0 15 0 0q�5^      $��Center=�5_      $��14(�5`      �� 5b      $��Ngày tham gia��6$   $��4��69   $��0 15 0 0q�5c      $��Center=�5d      $��14(�5e      �� 5g      $��Đơn vị phụ��6$   $��5��66   $��0 15 0 0q�5h      $��0��5i       $��Center=�5j      $��14(�5k      �� 5m      $��	Vị trí��6$   $��0��62   $��	15 15 0 0q�5n      $��2��5o       $��Center=�5p      $��14(�5q      �� 5s      $��Hợp đồng lao động��6$   $��1��6=   $��	15 15 0 0q�5t      $��2��5u       $��2��5v       $��Center=�5w      $��20(�5x      $
��Bold"�6*   $��	Noto Sans)�6<   �� 5z      $��Ngày bắt đầu��6$   $��2��68   $��	15 15 0 0q�5{      $��2��5|       $��Center=�5}      $��14(�5~      �� 5�      $��Ngày cuối��6$   $��3��65   $��	15 15 0 0q�5�      $��2��5�       $��Center=�5�      $��14(�5�      �� 5�      $��Chi tiết hợp đồng��6$   $��4��6=   $��	15 15 0 0q�5�      $��2��5�       $��Center=�5�      $��14(�5�      �� 5�      -   5         ��Name$ cbChucVu��5�      $��1��5�      $��0��5�      
�������   MaterialDesignFilledComboBox#��[ 5�      $��1q�5�      $��3 5 3 5q�5�       �� SelectedValuePath$
 Name��5�       �� DisplayMemberPath$
 Name��5�      {�5�      �� *	IsChecked+ �� ElementName$ 	checkEdit�� �� SelectedValue 5�      �� *
JobTitle+ �� Text 5�      �� *
JobTitle+ �� UpdateSourceTrigger$ PropertyChanged=�5�      �� 5�      $��1��5�      $��1��5�      $��5 15 5 5q�5�      $��Center=�5�      ��5�      �� *JobSpecification+$ PropertyChanged=�{�5�      �� *	IsChecked+$ 	checkEdit��5�      �� 5�      -   5        $ 	cbViecLam��5�      $��1��5�      $��2��5�      
�������#��[ 5�      $��1q�5�      $��3 15 3 5q�5�      $
 Name��5�      $
 Name��5�      {�5�      �� *	IsChecked+$ 	checkEdit�� 5�      �� *EmploymentStatus+ 5�      �� *EmploymentStatus+$ PropertyChanged=�5�      �� 5�      -   5        $ cbNganhNghe��5�      $��1��5�      $��3��5�      
�������#��[ 5�      $��1q�5�      $��3 15 3 5q�5�      $
 Name��5�      $
 Name��5�      {�5�      �� *	IsChecked+$ 	checkEdit�� 5�      �� *JobCategory+ 5�      �� *JobCategory+$ PropertyChanged=�5�      (  "System.Windows.Controls.DatePicker  5�      $��1��5�      $��4��5�      $��40��5�      $��5 15 5 5q�5�      $��1q�5�      $��5 0 5 0q�5�      
�������{�5�      �� *	IsChecked+$ 	checkEdit��   SelectedDate 5�      �� *
JoinedDate+$ PropertyChanged=�   Text 5�      �� *
JoinedDate+5�        5�      $��3��5�      $��2��5�      $��40��5�      $��5 15 5 5q�5�      $��1q�5�      $��5 0 5 0q�5�      
�������{�5�      �� *	IsChecked+$ 	checkEdit�� 5�      �� *	StartDate+$ PropertyChanged=� 5�      �� *	StartDate+5�      �� 5�      $��3��5�      $��4��5�      $��5 15 5 5q�5�      $��Center=�5�      {�5�      �� *	IsChecked+$ 	checkEdit����5�      �� *ContractDetails+$ PropertyChanged=�5�        5�      $��3��5�      $��3��5�      $��40��5�      $��5 15 5 5q�5�      $��1q�5�      $��5 0 5 0q�5�      
�������{�5�      �� *	IsChecked+$ 	checkEdit�� 5�      �� *	EndDate+$ PropertyChanged=� 5�      �� *	EndDate+5�      �� 5     $��1��5     $��5��5     
�������#��[ 5     $��1q�5     $��3 15 3 5q�5	     {�5     �� *	IsChecked+$ 	checkEdit�� 5     �� *	SubUnit+$ PropertyChanged=�5     �� 5     -   5        $ cbViTri��5     $��3��5     $��0��5     
�������#��[ 5     $��1q�5     $��3 5 3 5q�5     $
 Name��5     $
 Name��5     {�5     �� *	IsChecked+$ 	checkEdit�� 5     �� *
Location+ 5     �� *
Location+$ PropertyChanged=�5     5#     5$     �� 5&     $��1��6     MaterialDesignDarkSeparator#��[ 6'   $	��0 5q�6\   $��1��6i   $	��Top=�6v   �� 5(      �� Orientation$ 
Horizontal=�6   $��1��66   $��	0 10 0 10q�5)     $��Center=�5*     .+�5+     �� -	   5         ��Name$ btnSave��5+      # MaterialDesignFlatLightBgButton#��[ 6.   ���	#FF086912
�������$��0 0 10 0q�5.     $	��120��5/     
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��52     .��6C   SỬA ĐỔI54     �� 56     -
   5        #��[ 56     ���	#FF4D4D4D
�������$��0 0 10 0q�59     $	��120��5:     
������ $ 15��5=     y�5>     �� *	IsChecked+$ 	checkEdit��   BooleanToVisibilityConverter �� 	Converter# [ .��6�   
HỦY BỎ5@     �� 5B     -   5        #��[ 5B     ���	#FF4D4D4D
�������$��0 0 10 0q�5E     $��	20 0 20 0q�5F     
������ $ 15��5I     y�5J     �� *Status+# [ .��6p   Chấm dứt hợp đồng5L     �� 5N     -   5        $ btnKichHoat��5T     #��[ 5N     ���	#FF4D4D4D
�������$��0 0 10 0q�5Q     $��	20 0 20 0q�5R     
������ $ 15��5V     y�5W     �� *Status+# [  .��6e   Kích hoạt việc làm5Y     �� 5[     -   5        $ txtDate��5[      $��Center=�5\     $��	Underline{�67    � Cursor$
 Hand��6S   ��5[  1   �� *Date+# [   �� ConverterParameter#  [ y�5]     �� *
Visibility+$ btnKichHoat��5^      5_     5`     5a     5b     5c     