using SharedKernel;

namespace Domain.BaseEntitys;

public sealed record BaseEntityItemCompletedDomainEvent(Guid BaseEntityItemId) : IDomainEvent;
