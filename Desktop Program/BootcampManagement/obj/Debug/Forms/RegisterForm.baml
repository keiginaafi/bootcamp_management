   M S B A M L   `   `   `  ����M  IBootcampManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BootcampManagementBootcampManagement  5   	   %    BootcampManagement.RegisterForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BootcampManagement     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Register Form��5	   	   $	��773��6   $	��650��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N    � WindowStyle$
 None=�6s   .��5
      � -   5        .+�5   
   �� $��0,0,-0.4,690.6q�6   .+�5      � .+�5      �� -   5         ��Name$ 	Close_Btn��5      
�������$��Center=�6l    � ToolTip$ Close Application��6�   $��36��6�   $��36��6�    K� ZIndex$ 2��6�   $��613,0,0.6,737.6q�6�   ��6,   Z� ��6B   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6.   $��25��6;   $��25��6F   $��Center=�6R   $	��-10q�6o   5      � 5       � Points �    �� ���hx	 �� Left$	 35��5      

 �� Top$	
 -85��6&   $��590,0,0.6,698.6q�67   ��5      �� 5       �� Color$ #990000��6*   5      � 5      ! �   ��E"�6�&�hx�hx$	 38��5      $	
 -85��6&   $��0,0,0.2,671.6q�67   ��5      �� 5      $ #E8E8E8��6*   5      �� 5      -   5         ��Name$ 	textBlock��5      $��0,12,0,0q�6/   $
��Wrap=�6A   $��Register��6U   $	��Top=�6e   $��Center=�6}   $��35(�6�   ���#000066$��Yu Gothic UI Light)�6�   �� 5      	 �� X1$ 0��6   	 �� Y1$ 0��6   	 �� X2$	 650��6%   	 �� Y2$ 0��6.   ���#000066$��4��6F   $��0,81,-2.8,687.6q�6Z   5       5!      �� 5"   
   -   5        $��	MainPanel��5"      $��0,75,0,0q�6&   .+�5#      ��  �� Orientation$ 
Horizontal=�6   .+�5$      �� $
��Wrap=�6   $��First Name :��60   $��
30,20,20,0q�6D   $��12(�6X   $��Yu Gothic UI Bold)�6g   �� 5%      $
��Wrap=�6   $��Last Name :��60   $��229,20,20,0q�6C   $��12(�6X   $��Yu Gothic UI Bold)�6g   5&      �� 5'      $ 
Horizontal=�6   .+�5(      �� -   5         ��Name$ FirstName_Tbox��5(      $
��Left=�62   $��25��6M   $��30,5,0,0q�6Y    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��255��6�   $��Yu Gothic UI Light)�6�   �� 5)      -   5        $ LastName_Tbox��5)      $
��Left=�62   $��25��6M   $��60,5,0,0q�6Y   $
 Wrap=�6k   $	��Top=�6   $	��255��6�   $��Yu Gothic UI Light)�6�   5*      �� 5+      .+�5,      �� $
��Wrap=�6   $��Date of Birth :��60   $��	30,5,30,0q�6G   $��12(�6Z   $��Yu Gothic UI Bold)�6i   (  "System.Windows.Controls.DatePicker  5-      -   5          Name$ DateOfBirth_Dtp��5-      $
��Left=�66   $��30,5,0,0q�6Q   $	��Top=�6c   $	��255��6{   $��Yu Gothic UI Light)�6�   6�   5.      �� 5/      .+�50      �� $
��Wrap=�6   $��Status :��60   $��	30,5,20,0q�6@   $��12(�6S   $��Yu Gothic UI Bold)�6b   �� 51      -   5         ��Name$ Status_Cmbbox��51      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ -Select Status-��62   $
��Left=�6c   $��30,5,0,0q�6~   $	��Top=�6�   $	��255��6�   $��Yu Gothic UI Light)�6�   .@�52      �� .��6#   Single6+   �� 53      .��6#   	Married6,   54      55      �� 56      .+�57      �� $
��Wrap=�6   $��Gender :��60   $��	30,5,20,0q�6@   $��12(�6S   $��Yu Gothic UI Bold)�6b   �� 58      -	   5        $ Gender_Cmbbox��58      $ -Select Gender-��62   $
��Left=�6c   $��30,5,0,0q�6~   $	��Top=�6�   $	��255��6�   $��Yu Gothic UI Light)�6�   .@�59      �� .��6#   Male6)   �� 5:      .��6#   Female6+   �� 5;      .��6#   Other6*   5<      5=      �� 5>      .+�5?      �� $
��Wrap=�6   $��
Religion :��60   $��	30,5,20,0q�6B   $��12(�6U   $��Yu Gothic UI Bold)�6d   �� 5@      -
   5        $ Religion_Cmbbox��5@      $
��Left=�64   $��30,5,0,0q�6O   $	��Top=�6a   $	��255��6y   $��Yu Gothic UI Light)�6�    �� DisplayMemberPath$
 Name��5A   H    �� SelectedValuePath$ id��6a   $ -Select Religion-��5B      ��5A      ��  �� Source$ ReligionList��5B      5D      �� 5E      $ 
Horizontal=�6   .+�5F      �� .+�5G      �� $
��Wrap=�6    $��Email :��64   $��	30,5,20,0q�6C   $��12(�6V   $��Yu Gothic UI Bold)�6e   �� 5H      -   5        $ 
Email_Tbox��5H      $ Example@email.com��62   $
��Left=�6e   $��25��6�   $��30,5,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��375��6�   $��Yu Gothic UI Light)�6�   6�   5I      �� 5J      .+�5K      �� -   5        $ EmailValid_Txb��5K       $
��Wrap=�68   $��0,26,0,0q�6L   $
��auto��6^   $��10(�6k   $��Yu Gothic UI)�6z   ���	#FFDE0000$��22��6�   5L      5M      �� 5N      .+�5O      �� $
��Wrap=�6   $��	Contact :��60   $��	30,5,20,0q�6A   $��12(�6T   $��Yu Gothic UI Bold)�6c   �� 5P      -   5        $ Contact_Tbox��5P      $
��Left=�60   $��25��6K   $��30,5,0,0q�6W   $
 Wrap=�6i   $	��Top=�6}   $	��375��6�   $��Yu Gothic UI Light)�6�   6�   5Q      �� 5R      .+�5S      �� $
��Wrap=�6   $��Street Address :��60   $��	30,5,20,0q�6H   $��12(�6[   $��Yu Gothic UI Bold)�6j   �� 5T      -   5        $ StreetAddress_Tbox��5T      $
��Left=�66   $��	30,5,30,0q�6Q   $
 Wrap=�6d   $	��Top=�6x   $	��570��6�   $��Yu Gothic UI Light)�6�   5U      �� 5V      $ 
Horizontal=�6   .+�5W      �� $
��Wrap=�6   $��
Province :��60   $��	30,5,20,0q�6B   $��12(�6U   $��Yu Gothic UI Bold)�6d   �� 5X      $
��Wrap=�6   $��
Sub-City :��60   $��
241,5,20,0q�6B   $��12(�6V   $��Yu Gothic UI Bold)�6e   5Y      �� 5Z      $ 
Horizontal=�6   .+�5[      �� -   5        $ Province_Cmbbox��5[      $
��Left=�64   $��30,5,0,0q�6O   $	��Top=�6a   $	��255��6y   $��Yu Gothic UI Light)�6�   $
 Name��5\   H   $ id��6a   $ -Select Province-��5^      ��5\      �� $ ProvinceList��5^      �� 5`      -   5        $ SubCity_Cmbbox��5`      $
��Left=�63   $��60,5,0,0q�6N   $	��Top=�6`   $	��255��6x   $��Yu Gothic UI Light)�6�   $
 Name��5a   H   $ id��6a   $ -Select Sub-City-��5c      ��5a      �� $ SubCitytList��5c      5e      �� 5f      $ 
Horizontal=�6   .+�5g      �� $
��Wrap=�6   $��City :��60   $��	30,5,20,0q�6>   $��12(�6Q   $��Yu Gothic UI Bold)�6`   �� 5h      $
��Wrap=�6   $��	Village :��60   $��
268,5,20,0q�6A   $��12(�6U   $��Yu Gothic UI Bold)�6d   5i      �� 5j      $ 
Horizontal=�6   .+�5k      �� -   5        $ City_Cmbbox��5k      $
��Left=�60   $��30,5,0,0q�6K   $	��Top=�6]   $	��255��6u   $��Yu Gothic UI Light)�6�   $
 Name��5l   F   $ id��6_   $ -Select City-��5n      ��5l      �� $ 
RegionList��5n      �� 5p      -   5        $ Village_Cmbbox��5p      $
��Left=�63   $��60,5,0,0q�6N   $	��Top=�6`   $	��255��6x   $��Yu Gothic UI Light)�6�   $
 Name��5q   G   $ id��6`   $ -Select Village-��5r      ��5q      �� $ VillageList��5r      5t      �� 5u      $ 
Horizontal=�6   .+�5v      �� $
��Wrap=�6   $��
Password :��60   $��	30,5,20,0q�6B   $��12(�6U   $��Yu Gothic UI Bold)�6d   �� 5w      $
��Wrap=�6   $��
Password :��60   $��
237,5,20,0q�6B   $��12(�6V   $��Yu Gothic UI Bold)�6e   5x      �� 5y      $ 
Horizontal=�6   .+�5z      G� -   5         G�Name$ Password_Pbox��5z      $	��Top=�65   $
��Left=�6M   $��30,5,0,0q�6h   $	��Top=�6z   $	��255��6�   $��Yu Gothic UI Light)�6�   G� 5{      -   5        $ ConfirmPassword_Pbox��5{      $	��Top=�6<   $
��Left=�6T   $��60,5,0,0q�6o   $	��Top=�6�   $	��255��6�   $��Yu Gothic UI Light)�6�   5|      �� 5}      $ 
Horizontal=�6   $��	30,15,0,0q�62   .+�5~      �� -   5         ��Name$ TermOfUse_Check��5~         MaterialDesignCheckBox#��[  64   $��	10,-1,0,0q�6d   �� 5      $
��Wrap=�6   $��I Accept the��60   $��12(�6D   $��Yu Gothic UI Light)�6S   $��0,0,5,0q�6s   �� 5�      $
��Wrap=�6   $��Term of Use��60   $��12(�6D   $��Yu Gothic UI Bold)�6S   $��0,0,5,0q�6r   ���#000066 � Cursor$
 Hand��6�   �� 5�      $
��Wrap=�6   $��&��60   $��12(�6=   $��Yu Gothic UI Light)�6L   $��0,0,5,0q�6l   �� 5�      $
��Wrap=�6   $��Privacy Policy��60   $��12(�6F   $��Yu Gothic UI Bold)�6U   ���#000066$
 Hand��6�   5�      �� 5�      $ 
Horizontal=�6   $��55,20,35,25q�62   $	��Top=�6G   $��Right=�6_   .+�5�      �� -   5        $ 
Cancel_Btn��5�      $��Cancel��6-   $	��100��6>   $��35��6J   ���#FFCB48���#FFCB48$��Yu Gothic UI Light)�6�   $��0,0,25,0q�6�   6�   �� 5�      -   5        $ Register_Btn��5�      $��Register��6/   $	��100��6B   $��35��6N   $��Yu Gothic UI Light)�6Z   6z   5�      �� 5�      .+�5�      �� $ 0��6   $ 0��6   $	 650��6%   $ 0��6.   ���#000066$��4��6F   5�      5�      5�      5�      