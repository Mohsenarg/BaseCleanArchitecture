using SharedKernel;

namespace Domain.BaseEntitys;

public sealed record BaseEntityItemDeletedDomainEvent(Guid BaseEntityItemId) : IDomainEvent;
