   M S B A M L   `   `   `  ����K  GQuangsTradingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QuangsTradingAppQuangsTradingApp  5   	   &     QuangsTradingApp.EditStockWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:QuangsTradingApp     5   	     � Title$  Edit Stock Details��5   	   $	��300��6$   $	��300��61   .��5	      � 
�������$��10q�6!    � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Center=�6/   .��6J   
Stock name6V   �� 5   
   -   5        $��NewStockTextBox��5   J   $��0��6   $��1��6   $��Center=�6/   6J   �� 5   
   $��1��6   $��0��6    $��Center=�60   .��6K   Number6S   �� 5   
   -   5        $��NewStockNumber��5   K   $��1��6   $��1��6    $��Center=�60   6K   �� 5   
   $��2��6   $��0��6    $��Center=�60   .��6K   Minimum Price6Z   �� 5   
   -   5        $��NewMinPrice��5   K   $��2��6   $��1��6    $��Center=�60   6K   �� 5    
   $��3��6   $��0��6    $��Center=�60   .��6K   Maximum Price6Z   �� 5!   
   -   5        $��NewMaxPrice��5!   K   $��3��6   $��1��6    $��Center=�60   6K   �� 5#   
   $��4��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $
��0 10q�6g   .+�5$      �� -   5        $��OKButton��5$       �� 	IsDefault . $��Center=�6:   $��0 0 5 0q�6U   .��6}   OK6�   �� 5%      -   5        $��CancelButton��5%       �� IsCancel . $��Center=�6:   .��6U   Cancel6]   5&      5'      5(      