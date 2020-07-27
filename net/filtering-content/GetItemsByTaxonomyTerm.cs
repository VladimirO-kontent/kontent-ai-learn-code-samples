// DocSection: filtering_get_items_by_taxonomy_term
// Note: Filters work with codenames of the tags.
// Gets items tagged with a specific tag
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new ContainsFilter("elements.tags", "kontent")
);

// Gets items tagged with a specific list of tags
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new AllFilter("elements.tags", "kontent", "headless")
);

// Gets items tagged with at least one tag from the list
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  new AnyFilter("elements.tags", "football", "soccer")
);
// EndDocSection