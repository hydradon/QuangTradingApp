   M S B A M L   `   `   `  ����K  GQuangsTradingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:QuangsTradingAppQuangsTradingApp  5   	   "    QuangsTradingApp.TradeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:QuangsTradingApp     5   	     � Title$  Trade Stock��5   	   $	��392��6   $	��300��6*   .��5
      � 
�������$��10q�6"    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Center=�6/   .��6J   
Stock name6V   �� 5   
   -   5        $��NewStockTextBox��5   L   $��0��6   $��1��6!   $��Center=�61   6L   �� 5   
   $��1��6   $��0��6    $��Center=�60   .��6K   Number6S   �� 5   
   -   5        $��NewStockNumber��5   M   $��1��6   $��1��6"   $��Center=�62   6M   �� 5   
   $��2��6   $��0��6    $��Center=�60   .��6K   Minimum Price6Z   �� 5    
   -   5        $��NewMinPrice��5    M   $��2��6   $��1��6"   $��Center=�62   6M   �� 5"   
   $��3��6   $��0��6    $��Center=�60   .��6K   Maximum Price6Z   �� 5#   
   -   5        $��NewMaxPrice��5#   M   $��3��6   $��1��6"   $��Center=�62   6M   � 5%   
   $��4��6   $��1��6!    � Orientation$ 
Horizontal=�61   $��Right=�6J   $
��0 10q�6f   .+�5'      �� -   5         ��Name$	 Buy��5'       �� 	IsDefault . $��Center=�67   $��5 5 5 5q�6R    J� RenderTransformOrigin$ 0.682,-0.394&�6c   $	��Buy��6�   6�   �� 5(      -   5        $
 Sell��5(      $��Center=�6'   $��5 5 5 5q�6B   $
��Sell��6S   6b   �� 5)      -   5        $ CancelButton��5)       �� IsCancel . $��Center=�6<   $��Cancel��6W   $��5 5 5 5q�6h   5*      �� 5,   
   -   5         ��Name$ NumTradeLabel��5,      $��Number to Trade��6'   $��9(�6A   $��Center=�6O   $��
10,10,10,0q�6l   $��4��6�   $	��Top=�6�   $��25��6�   $��80��6�   �� 5-   
   -	   5        	 ��Name$	 NumbTradeTextBox��5-      $
��Left=�6,   $��23��6G   $��	10,35,0,0q�6S   $��4��6f   
 �� TextWrapping$

 Wrap=�6s   $��0��6�   $	��Top=�6�   $��80��6�   5.      5/      