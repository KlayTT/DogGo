                       SELECT w.Id, w.[Name], w.ImageUrl, n.[Name] AS NeighborhoodName
                       FROM Walker w
                       LEFT OUTER JOIN Neighborhood n ON w.NeighborhoodId = n.Id

